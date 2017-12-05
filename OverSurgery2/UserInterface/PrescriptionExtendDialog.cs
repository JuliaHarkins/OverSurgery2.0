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
    public partial class PrescriptionExtendDialog : Form
    {
        private Prescription m_extendPres;
        private Patient m_currPatient;
        public PrescriptionExtendDialog(ViewPatientInfoForm vcp, Prescription p_Prescription)
        {
            m_extendPres = p_Prescription;
            m_currPatient = vcp.GetCurrentPatient();
            InitializeComponent();
        }

        private void PrescriptionExtendDialog_Load(object sender, EventArgs e)
        {
            lbl_MedicationText.Text = MetaLayer.Instance().GetMedicationName(m_extendPres.MedicationID);
            lbl_PatientText.Text = $"{m_currPatient.Forename} {m_currPatient.Surname}";
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            if (!(m_extendPres.DateOfNextIssue <= DateTime.Now))
            {
                MessageBox.Show(
                    "This prescription cannot be extended yet");
            }
            else if (!m_extendPres.Extendable)
            {
                MessageBox.Show("This prescription cannot be extended. Please refer the patient to their GP.");
            }
            else
            {
                Extension ext = new Extension()
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
