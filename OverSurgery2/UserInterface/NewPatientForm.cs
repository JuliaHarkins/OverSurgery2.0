using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            dtp_DateOfBirth.MaxDate = DateTime.Now;
            dtp_DateOfBirth.MinDate = DateTime.Parse("1900-01-01");
            cbx_Gender.DataSource = Enum.GetValues(typeof(Patient.Genders));
        }

        private void btn_SavePatient_Click(object sender, EventArgs e)
        {
            bool controlsValidated = false;
            StringBuilder sb = new StringBuilder();
            bool numNameVal = false;
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if(tb.Text == String.Empty)
                    {
                        #region String Builder Switch
                        // Switch on name of TextBox, add appropriate string to StringBuilder.
                        switch(tb.Name)
                        {
                            case "txt_Forename":
                                sb.Append("Forename must not be empty\r\n");
                                break;
                            case "txt_Surname":
                                sb.Append("Surname must not be empty\r\n");
                                break;
                            case "txt_PhoneNumber":
                                sb.Append("Phone Number must not be empty\r\n");
                                break;
                            case "txt_HouseName":
                                if (txt_HouseNumber.Text == String.Empty && !numNameVal)
                                {
                                    sb.Append("You must provide either a house name or number\r\n");
                                    numNameVal = true;
                                }
                                break;
                            case "txt_HouseNumber":
                                if (txt_HouseName.Text == String.Empty && !numNameVal)
                                {
                                    sb.Append("You must provide either a house name or number\r\n");
                                    numNameVal = true;
                                }
                                break;
                            case "txt_Street":
                                sb.Append("Street name must not be empty\r\n");
                                break;
                            case "txt_PostCode":
                                sb.Append("Postcode must not be empty\r\n");
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
            if (controlsValidated)
            {
                Address a = new Address
                {
                    HouseName = txt_HouseName.Text,
                    HouseNumber = Convert.ToInt32(txt_HouseNumber.Text),
                    StreetName = txt_Street.Text,
                    PostCode = txt_PostCode.Text
                };
                MetaLayer.Instance().AddAddress(a);
                Patient p = new Patient
                {
                    Forename = txt_Forename.Text,
                    Surname = txt_Surname.Text,
                    DateOfBirth = dtp_DateOfBirth.Value,
                    Gender = (int)cbx_Gender.SelectedValue,
                    PhoneNumber = txt_PhoneNumber.Text,
                };
            }
        }
    }
}
