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
