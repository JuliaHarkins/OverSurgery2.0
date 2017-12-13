using System;
using System.Windows.Forms;

namespace OverSurgery2
{
    public partial class PrescriptionExtendDialog : Form
    {
        private readonly Prescription m_extendPres;
        private readonly Patient m_currPatient;

        public PrescriptionExtendDialog(ViewPatientInfoForm p_vcp, Prescription p_prescription)
        {
            m_extendPres = p_prescription;
            m_currPatient = p_vcp.GetCurrentPatient();
            InitializeComponent();
        }

        private void PrescriptionExtendDialog_Load(object sender, EventArgs e)
        {
            lbl_MedicationText.Text = MetaLayer.Instance().GetMedicationName(m_extendPres.MedicationID);
            lbl_PatientText.Text = $"{m_currPatient.Forename} {m_currPatient.Surname}";
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            //Check that the date of next issue is not before or on current date.
            if (!(m_extendPres.DateOfNextIssue <= DateTime.Now))
            {
                MessageBox.Show("This prescription cannot be extended yet");
            }
            //If prescription not extendable
            else if (!m_extendPres.Extendable)
            {
                MessageBox.Show("This prescription cannot be extended. Please refer the patient to their GP.");
            }
            else
            {
                var ext = new Extension
                {
                    PrescriptionID = m_extendPres.ID,
                    MedicalStaffID = m_extendPres.MedicalStaffID,
                    DateOfExtension = m_extendPres.Date,
                    Reason = txt_Reason.Text,
                    ExtentionID = 0,
                    Extended = 0
                };
                MetaLayer.Instance().NewExtension(ext);
                MessageBox.Show("Extension Request sent!");
                Close();
            }
        }
    }
}