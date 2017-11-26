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
        BindingSource PatientPres;
        List<Prescription> m_PatientPrescriptions;
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
            PatientPres = new BindingSource();
            Address ad = MetaLayer.Instance().GetAddressByID(Convert.ToInt16(currentPatient.AddressID));
            this.Text = "Viewing Patient - " + currentPatient.Forename + " " + currentPatient.Surname;
            lbl_ForenameText.Text = currentPatient.Forename;
            lbl_SurnameText.Text = currentPatient.Surname;
            TimeSpan yearsOld = (DateTime.Now - currentPatient.DateOfBirth);
            var yearsVal = yearsOld.Days / 365;
            var monthsVal = (yearsOld.Days - yearsVal * 365) / 30;
            lbl_DateOfBirthText.Text = currentPatient.DateOfBirth.ToShortDateString() + " (" + yearsVal + " Years, " + monthsVal + " Months)";
            lbl_PhoneNumberText.Text = currentPatient.PhoneNumber;
            lbl_DoctorNameText.Text = currentPatient.DoctorDisplay;
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
            m_PatientPrescriptions = ml.GetPatientsPrescriptions(currentPatient.ID);
            lst_PatientsPres.Clear();
            lst_PatientsPres.Columns.Add("Date");
            lst_PatientsPres.Columns.Add("Medication");
            lst_PatientsPres.Columns.Add("Amount");
            lst_PatientsPres.Columns.Add("By");
            foreach (Prescription p in m_PatientPrescriptions)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Date.ToShortDateString();
                lvi.SubItems.Add(ml.GetMedicationName(p.MedicationID));
                lvi.SubItems.Add(p.Amount.ToString());
                //using the medStaff id, I get the staff id and find out the full title and name of the medicalStaff member
                lvi.SubItems.Add(ml.GetStaffNameAndTitle(ml.GetStafIDFromMedStaffID(p.MedicalStaffID)));
                lst_PatientsPres.Items.Add(lvi);
            }
            foreach (ColumnHeader column in lst_PatientsPres.Columns)
            {
                column.Width = -2;
            }
        }

        private void ViewPatientInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void lst_PatientsPres_Click(object sender, EventArgs e)
        {
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            int sel = lst_PatientsPres.SelectedIndices[0];
            var pres = m_PatientPrescriptions.ElementAt(sel);
            pres.Extend();
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
