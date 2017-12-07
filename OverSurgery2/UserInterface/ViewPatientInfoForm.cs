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
        public Patient currentPatient { get; set; }
        MetaLayer ml;
        FormController fc;
        BindingSource PatientPres;
        List<Prescription> m_PatientPrescriptions;
        private int selectedP;


        public ViewPatientInfoForm(Patient p_Patient)
        {
            currentPatient = p_Patient;
            InitializeComponent();
            ml = MetaLayer.Instance();
            fc = FormController.Instance();
            
        }

        public Patient GetCurrentPatient()
        {
            return currentPatient; 
        }


        private void btn_EditPatient_Click(object sender, EventArgs e)
        {
            fc.OpenEditPatientForm(currentPatient);
            PatientController.Instance().UpdatePatientDoctorDisplay();
        }

        private void ViewPatientInfoForm_Load(object sender, EventArgs e)
        {
            #region Execution
            PatientPres = new BindingSource();
            Address ad = MetaLayer.Instance().GetAddressById(Convert.ToInt16(currentPatient.AddressID));
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
            else if(ad.HouseName != "" && ad.HouseNumber !=null)
            {
                lbl_HouseNameNumberText.Text = $"{ad.HouseNumber} {ad.HouseName}";
            }
            lbl_StreetNameText.Text = ad.StreetName;
            lbl_PostCodeText.Text = ad.PostCode;
            m_PatientPrescriptions = ml.GetPatientsPrescriptions(currentPatient.ID);
            var PrescriptionListBind = new BindingList<Prescription>(m_PatientPrescriptions);
            var PrescriptionBinding = new BindingSource(PrescriptionListBind,null);
            dgv_PatientsPres.RowHeadersVisible = false;
            dgv_PatientsPres.Columns.Add("MedicationDisplay", "Medication");
            dgv_PatientsPres.DataSource = PrescriptionBinding;

            foreach (DataGridViewRow row in dgv_PatientsPres.Rows)
            {
                if (row.Cells["MedicationDisplay"].Value == null)
                {
                    row.Cells["MedicationDisplay"].Value = Convert.ToString(MetaLayer.Instance()
                        .GetMedicationName(Convert.ToInt32(row.Cells["MedicationID"].Value)));
                }
            }
            foreach (DataGridViewColumn c in dgv_PatientsPres.Columns)
            {
                c.Visible = false;
            }
            dgv_PatientsPres.Columns["MedicationDisplay"].Visible = true;
            dgv_PatientsPres.Columns["Date"].Visible = true;
            dgv_PatientsPres.Columns["ID"].DisplayIndex = 2;
            dgv_PatientsPres.Columns["MedicationDisplay"].DisplayIndex = 1;

            #endregion
        }

        private void ViewPatientInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            Prescription pres;
            try
            {
                pres = m_PatientPrescriptions.FirstOrDefault(p =>
                    p.ID == Convert.ToInt16(dgv_PatientsPres.CurrentRow.Cells["ID"].Value));
                if (pres == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    new PrescriptionExtendDialog(this, pres).ShowDialog();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Prescription not selected");
            }

        }

        private void dgv_PatientsPres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedP = Convert.ToInt16(dgv_PatientsPres.CurrentRow.Cells[0].Value);
        }
    }
    public class Address
    {
        int m_ID;
        string m_houseName;
        int? m_houseNumber;
        string m_postCode;
        string m_streetName;

        public int AddressID { get { return m_ID; } set { m_ID = value; } }
        public string HouseName { get { return m_houseName; } set { m_houseName = value; } }
        public int? HouseNumber { get { return m_houseNumber; } set { m_houseNumber = value; } }
        public string PostCode { get { return m_postCode; } set { m_postCode = value; } }
        public string StreetName { get { return m_streetName; } set { m_streetName = value; } }
    }
}
