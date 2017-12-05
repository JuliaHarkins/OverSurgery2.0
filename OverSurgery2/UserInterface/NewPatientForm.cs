using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
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
        }

        public NewPatientForm(Patient p_patient)
        {
            InitializeComponent();
            m_updateflg = true;
            editPatient = p_patient;
            PopulateFields(p_patient);
            
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            dtp_DateOfBirth.MaxDate = DateTime.Now;
            dtp_DateOfBirth.MinDate = DateTime.Parse("1900-01-01");

        }

        private void btn_SavePatient_Click(object sender, EventArgs e)
        {
            
                Address a = new Address
                {
                    HouseName = txt_HouseName.Text,
                    HouseNumber = Convert.ToInt32(txt_HouseNumber.Text),
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
                    //int addressid = MetaLayer.Instance().AddAddress(a);
                    //p.AddressID = (uint)addressid;
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
                    p.ID = editPatient.ID;
                    MessageBox.Show(cbx_Gender.SelectedIndex.ToString());
                    MetaLayer.Instance().UpdateAddress(a,Convert.ToInt32(editPatient.AddressID));
                    MetaLayer.Instance().UpdatePatient(p);
                    PatientController.Instance().UpdatePatientList();
                    Close();
                    
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
            if (!controlsValidated)
            {
                MessageBox.Show(sb.ToString());
            }
            return controlsValidated;
        }

        private void PopulateFields(Patient p_patient)
        {
            m_updateflg = true;
            //MessageBox.Show(cbx_Gender.SelectedIndex.ToString());
            cbx_Gender.SelectedIndex = p_patient.Gender;
            txt_Forename.Text = p_patient.Forename;
            txt_Surname.Text = p_patient.Surname;
            dtp_DateOfBirth.Value = p_patient.DateOfBirth;
            dtp_DateOfBirth.Enabled = false;
            txt_PhoneNumber.Text = p_patient.PhoneNumber;
            txt_HouseName.Text = MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).HouseName;
            txt_HouseName.Text = Convert.ToString(MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).HouseNumber);
            txt_PostCode.Text = MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).PostCode;
            txt_Street.Text = MetaLayer.Instance().GetAddressById(Convert.ToInt16(p_patient.AddressID)).StreetName;
            //cbx_Gender.SelectedIndex = cbx_Gender.Items.IndexOf(cbx_Gender.Text);
            //cbx_Gender.SelectedValue = cbx_Gender.SelectedIndex = p_patient.Gender;

        }
    }
}
