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
    public partial class AddPrescription : Form
    {
        #region Members
        MetaLayer ml = MetaLayer.Instance();
        MedicalStaff m_currentUser;
        List<Medication> m_medication;
        int m_patientID;
        string m_patientName;
        #endregion
        public AddPrescription(Staff p_currentUser, int p_patientID, string p_patientName)
        {
            m_currentUser = p_currentUser as MedicalStaff;
            m_patientID = p_patientID;
            m_patientName = p_patientName;
            m_medication = ml.GetMedicationOnMedStaffID(m_currentUser.MedicalStaffID);
            InitializeComponent();

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            lb_patient.Text = "Prescription For : " + m_patientName;
            #region hideExtention
            lb_dateOfNextIssue.Hide();
            dtp_dateOfNextExtention.Hide();
            #endregion
            #region LoadMedication
            lst_medication.Columns.Add("Medication", 125);
            lst_medication.Columns.Add("Dosage", 75);
            lst_medication.Columns.Add("Permission Level", 95);

            loadList();

            #endregion

        }
        private void btn_savePrescription_Click(object sender, EventArgs e)
        {
            if ((lst_medication.SelectedIndices.Count != 0 && nud_amount.Value > 0) && (cb_extenable.Checked == false || (cb_extenable.Checked && dtp_dateOfNextExtention.Value > DateTime.Now))) {
                Prescription p = new Prescription();

                int i = lst_medication.SelectedIndices[0];
                p.MedicationID = Convert.ToUInt16(m_medication[i].ID);
                p.PatientID = m_patientID;
                p.MedicalStaffID = Convert.ToInt16(m_currentUser.MedicalStaffID);
                p.Amount = Convert.ToInt16(nud_amount.Value);
                p.Extendable = cb_extenable.Checked;
                if (p.Extendable)
                {
                    p.DateOfNextIssue = Convert.ToDateTime(dtp_dateOfNextExtention.Value);
                }
                p.Date = DateTime.Now;

                ml.AddPrescriptionToTheDatabase(p);
                this.Close();
            } else if (nud_amount.Value <= 0 && lst_medication.SelectedIndices.Count == 0)
            {
                ErrorBox("A prescription requires a medication and an amount.");
            }
            else if (nud_amount.Value <= 0)
            {
                ErrorBox("A prescription requires an amount greater than zero.");

            }
            else if (cb_extenable.Checked && dtp_dateOfNextExtention.Value < DateTime.Now)
            {
                ErrorBox("Date of next issue must be in the future");
            }
            else
            {
                ErrorBox("A prescription requires a medication.");
            }

        }
        private void lst_medication_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void lb_notes_Click(object sender, EventArgs e)
        {

        }
        private void lb_dateOfNextIssue_Click(object sender, EventArgs e)
        {

        }
        private void lb_patient_Click(object sender, EventArgs e)
        {

        }
        private void dtp_dateOfNextExtention_ValueChanged(object sender, EventArgs e)
        {

        }
        private void nud_amount_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cb_extenable_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_extenable.Checked)
            {
                lb_dateOfNextIssue.Show();
                dtp_dateOfNextExtention.Show();
            }
            else
            {
                lb_dateOfNextIssue.Hide();
                dtp_dateOfNextExtention.Hide();
            }
        }
        private void loadList()
        {
            foreach (Medication m in m_medication)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.Name.ToString();
                lvi.SubItems.Add(m.Dosage.ToString());
                lvi.SubItems.Add(m.PermissionLevel.ToString());
                lst_medication.Items.Add(lvi);
            }
        }
        /// <summary>
        /// creates an error message box with the given message.
        /// </summary>
        /// <param name="p_message"></param>
        private void ErrorBox(string p_message)
        {
            MessageBox.Show(p_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
