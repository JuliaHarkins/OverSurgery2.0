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
    public partial class MedicalExtention : Form
    {
        MetaLayer ml = MetaLayer.Instance();
        int m_staffID;
        List<Prescription> m_prescriptions;
        List<Extension> m_extensions;
        public MedicalExtention(int p_staffID)
        {
            m_staffID = p_staffID;
            InitializeComponent();
        }

        private void MedicalExtention_Load(object sender, EventArgs e)
        {

            // LoadExtentions
            lst_extention.Columns.Add("Forename", 100);
            lst_extention.Columns.Add("Surname", 100);
            lst_extention.Columns.Add("Medication", 100);
            lst_extention.Columns.Add("Amount", 75);
            lst_extention.Columns.Add("Date Issued", 70);
            lst_extention.Columns.Add("Reason", 135);

            LoadList();
        }
        
        private void btn_decline_Click(object sender, EventArgs e)
        {
            updateExtention(2);
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            updateExtention(1);
        }
#region Methoods
        /// <summary>
        /// reloads the extention list.
        /// </summary>
        private void LoadList()
        {
            m_extensions = ml.GetExtentionRequests(m_staffID);
            m_prescriptions = ml.GetExtentedPrescriptions(m_staffID);

            lst_extention.Items.Clear();
            int i = 0;
            Prescription p;
            foreach (Extension ex in m_extensions)
            {
                p = m_prescriptions[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = PatientController.Instance().patients.Find(pa => (pa.ID == p.PatientID)).Forename;
                lvi.SubItems.Add(PatientController.Instance().patients.Find(pa => (pa.ID == p.PatientID)).Surname);
                lvi.SubItems.Add(ml.GetMedicationName(p.MedicationID));
                lvi.SubItems.Add(Convert.ToString(p.Amount));

                lvi.SubItems.Add(p.Date.ToShortDateString());
                lvi.SubItems.Add(ex.Reason);

                lst_extention.Items.Add(lvi);

                i++;
            }
        }
        /// <summary>
        /// updates the state of an to the givin state 
        /// </summary>
        /// <param name="p_newState"></param>
        private void updateExtention(int p_newState)
        {
            if (lst_extention.SelectedIndices.Count > 0 && lst_extention.SelectedIndices[0] <= lst_extention.Items.Count)
            {
                int i = lst_extention.SelectedIndices[0];
                Extension ex = m_extensions[i];
                ex.Extended = p_newState;
                ml.UpdateExtention(ex.ExtentionID, p_newState);
                LoadList();
            }
        }
        #endregion
    }
}
