using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2
{
    public partial class NewPatientForm : Form
    {
        private bool m_updateflg;
        private Patient editPatient;
        public NewPatientForm()
        {
            InitializeComponent();
            m_updateflg = false;
            dtp_DateOfBirth.MaxDate = DateTime.Today.AddHours(1);
            dtp_DateOfBirth.MinDate = DateTime.Parse("1900-01-01");
            dtp_DateOfBirth.Value = DateTime.Today;
        }

        public NewPatientForm(Patient p_patient)
        {
            InitializeComponent();
            m_updateflg = true;
            dtp_DateOfBirth.MaxDate = DateTime.Today.AddHours(1);
            dtp_DateOfBirth.MinDate = DateTime.Parse("1900-01-01");
            editPatient = p_patient;
            PopulateFields(p_patient);
            
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_SavePatient_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Address a = new Address
                {
                    HouseName = txt_HouseName.Text,
                    HouseNumber = (txt_HouseNumber.Text != "") ? Convert.ToInt32(txt_HouseNumber.Text) :0,
                    StreetName = txt_Street.Text,
                    PostCode = txt_PostCode.Text
                };
                Patient p = new Patient
                {
                    Forename = txt_Forename.Text,
                    Surname = txt_Surname.Text,
                    DateOfBirth = dtp_DateOfBirth.Value.Date,
                    Gender = cbx_Gender.SelectedIndex,
                    PhoneNumber = txt_PhoneNumber.Text,
                };
                if (!m_updateflg)
                {
                    string passedData;
                    string column;
                    // Build the database query to send to the metalayer
                    if (a.HouseName != null && a.HouseNumber == 0)
                    {
                        column = "(AddressID, HouseName, AddressLine1, PostCode)";
                        passedData = $"null, '{a.HouseName}', '{a.StreetName}', '{a.PostCode}'";
                    }
                    else if (a.HouseNumber != 0 && a.HouseName == null)
                    {
                        column = "(HouseNumber, AddressLine1, PostCode)";
                        passedData = $"{a.HouseNumber}, '{a.StreetName}', '{a.PostCode}'";
                    }
                    else
                    {
                        column = null;
                        passedData = $"null, '{a.HouseName}', {a.HouseNumber}, '{a.StreetName}', '{a.PostCode}'";
                    }
                    p.AddressID = (uint) MetaLayer.Instance().AddAddress(a, column, passedData);
                    p.RegisteredDoctorID = MetaLayer.Instance().getDoctorWithLowestPatient();

                    if (!MetaLayer.Instance().InsertNewPatient(p))
                    {
                        MessageBox.Show(@"Sorry, this patient cannot be added");
                    }
                    foreach (Control c in Controls)
                    {
                        if (!(c is TextBox)) continue;
                        TextBox tb = c as TextBox;
                        tb.Text = "";
                    }
                    Close();
                    PatientController.Instance().UpdatePatientList();
                }
                else
                {
                    p.AddressID = editPatient.AddressID;
                    a.AddressID = (int) editPatient.AddressID;
                    p.ID = editPatient.ID;
                    MetaLayer.Instance().UpdateAddress(a, Convert.ToInt32(editPatient.AddressID));
                    MetaLayer.Instance().UpdatePatient(p);
                    PatientController.Instance().UpdatePatientList();
                    Close();

                }
            }
        }
        

        private bool ValidateFields()
        {
            bool controlsValidated = true;
            StringBuilder sb = new StringBuilder();
            bool numNameVal = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (tb.Text == String.Empty)
                    {
                        #region String Builder Switch
                        // Switch on name of TextBox, add appropriate string to StringBuilder.
                        switch (tb.Name)
                        {
                            case "txt_Forename":
                                sb.Append("Forename must not be empty\r\n");
                                controlsValidated = false;
                                break;
                            case "txt_Surname":
                                sb.Append("Surname must not be empty\r\n");
                                controlsValidated = false;
                                break;
                            case "txt_PhoneNumber":
                                sb.Append("Phone Number must not be empty\r\n");
                                controlsValidated = false;

                                break;
                            case "txt_HouseName":
                                if (txt_HouseNumber.Text == String.Empty && !numNameVal)
                                {
                                    sb.Append("You must provide either a house name or number\r\n");
                                    controlsValidated = false;
                                    numNameVal = true;
                                }
                                break;
                            case "txt_HouseNumber":
                                if (txt_HouseName.Text == String.Empty && !numNameVal)
                                {
                                    sb.Append("You must provide either a house name or number\r\n");
                                    controlsValidated = false;
                                    numNameVal = true;
                                }
                                break;
                            case "txt_Street":
                                sb.Append("Street name must not be empty\r\n");
                                controlsValidated = false;
                                break;
                            case "txt_PostCode":
                                sb.Append("Postcode must not be empty\r\n");
                                controlsValidated = false;
                                break;
                        }

                        #endregion
                    }

                }
            }
            Regex noLetter = new Regex(@"[a-zA-Z^+^\-^\/^\*^\(^\)]");
            Regex noSym = new Regex(@"[+^\-^\/^\*^\(^\)]");
            Regex noNum = new Regex(@"[0-9^+^\-^\/^\*^\(^\)]");
            Regex postformat = new Regex(@"^[a-zA-Z]{2}[0-9]{1,2}\s?[0-9][a-zA-Z]{2}$");
            MatchCollection pnMatches = noLetter.Matches(txt_PhoneNumber.Text);
            MatchCollection fnameMatches = noNum.Matches(txt_Forename.Text);
            MatchCollection snameMatches = noNum.Matches(txt_Surname.Text);
            MatchCollection addnameMatches = noNum.Matches(txt_HouseName.Text);
            MatchCollection addnumMatches = noLetter.Matches(txt_HouseNumber.Text);
            MatchCollection pcodeMatches = noSym.Matches(txt_PostCode.Text);
            MatchCollection pcodeformatMatches = postformat.Matches(txt_PostCode.Text);

            
            if (pnMatches.Count > 0)
            {
                sb.Append("Phone Number can only contain numbers\n");
                controlsValidated = false;
            }
            if (fnameMatches.Count > 0)
            {
                sb.Append("Forename can only contain letters\n");
                controlsValidated = false;
            }
            if (snameMatches.Count > 0)
            {
                sb.Append("Surname can only contain letters\n");
                controlsValidated = false;
            }
            if (addnameMatches.Count > 0)
            {
                sb.Append("House Name can only contain letters\n");
                controlsValidated = false;
            }
            if (addnumMatches.Count > 0)
            {
                sb.Append("House Number can only contain numbers\n");
                controlsValidated = false;
            }
            if (pcodeMatches.Count > 0)
            {
                sb.Append("Postcode can only contain numbers and letters\n");
                controlsValidated = false;
            }
            if (pcodeformatMatches.Count == 0)
            {
                sb.Append("Postcode needs to be in format AA11 1AB/AA1 1AB/AA111AB/AA11AB\n");
                controlsValidated = false;
            }
            
            if (!controlsValidated)
            {
                MessageBox.Show(sb.ToString());
            }
            return controlsValidated;
        }

        private void PopulateFields(Patient p_patient)
        {
            m_updateflg = true;
            cbx_Gender.SelectedIndex = p_patient.Gender;
            txt_Forename.Text = p_patient.Forename;
            txt_Surname.Text = p_patient.Surname;
            dtp_DateOfBirth.Value = p_patient.DateOfBirth.Date;
            dtp_DateOfBirth.Enabled = false;
            txt_PhoneNumber.Text = p_patient.PhoneNumber;
            txt_HouseName.Text = MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).HouseName;
            txt_HouseName.Text = Convert.ToString(MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).HouseNumber);
            txt_PostCode.Text = MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).PostCode;
            txt_Street.Text = MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).StreetName;

        }
    }
}
