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
    public partial class ViewPatientInfoForm : Form
    {
        Patient currentPatient;
        MetaLayer ml;
        FormController fc;
        public ViewPatientInfoForm(Patient p_Patient)
        {
            currentPatient = p_Patient;
            InitializeComponent();
            ml = MetaLayer.Instance();
            fc = FormController.Instance();
            
        }


        private void btn_EditPatient_Click(object sender, EventArgs e)
        {
            fc.OpenEditPatientForm(currentPatient);
        }

        private void ViewPatientInfoForm_Load(object sender, EventArgs e)
        {
            Address ad = MetaLayer.Instance().NewGetAddressByID(Convert.ToInt16(currentPatient.AddressID));
            this.Text = "Viewing Patient - " + currentPatient.Forename + " " + currentPatient.Surname;
            lbl_ForenameText.Text = currentPatient.Forename;
            lbl_SurnameText.Text = currentPatient.Surname;
            lbl_DateOfBirthText.Text = currentPatient.DateOfBirth.ToShortDateString();
            if(ad.HouseName == "")
            {
                lbl_HouseNameNumberText.Text = Convert.ToString(ad.HouseNumber);
            }
            else if(ad.HouseNumber == null)
            {
                lbl_HouseNameNumberText.Text = ad.HouseName;
            }
            lbl_StreetNameText.Text = ad.StreetName;
            lbl_PostCodeText.Text = ad.PostCode;
        }

        private void ViewPatientInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
    public class Address
    {
        string m_houseName;
        int? m_houseNumber;
        string m_postCode;
        string m_streetName;

        public string HouseName { get { return m_houseName; } set { m_houseName = value; } }
        public int? HouseNumber { get { return m_houseNumber; } set { m_houseNumber = value; } }
        public string PostCode { get { return m_postCode; } set { m_postCode = value; } }
        public string StreetName { get { return m_streetName; } set { m_streetName = value; } }
    }
}
