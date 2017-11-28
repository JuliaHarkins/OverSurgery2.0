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
        public MedicalExtention(int p_staffID)
        {
            m_staffID = p_staffID;
            InitializeComponent();
        }

        private void MedicalExtention_Load(object sender, EventArgs e)
        {
            m_prescriptions = ml.GetExtentionRequests(m_staffID);
            
            #region LoadExtentions
            lst_extention.Columns.Add("Medication", 125);
            lst_extention.Columns.Add("Amount", 75);
            lst_extention.Columns.Add("Forename", 125);
            lst_extention.Columns.Add("Surname", 125);
            lst_extention.Columns.Add("Date Issued", 75);

            LoadList();
            #endregion
        }
        private void LoadList()
        { 
        foreach (Prescription p in m_prescriptions)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ml.GetMedicationName(p.MedicationID);
                lvi.SubItems.Add(Convert.ToString(p.Amount));
                lvi.SubItems.Add(PatientController.Instance().patients.Find(pa => (pa.ID == p.PatientID)).Forename);
                lvi.SubItems.Add(PatientController.Instance().patients.Find(pa => (pa.ID == p.PatientID)).Surname);
                lvi.SubItems.Add(p.Date.ToShortDateString());
                lst_extention.Items.Add(lvi);
            }
        }
        private void lst_extention_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            int i = lst_extention.SelectedIndices[0];
            Prescription p = m_prescriptions[i];

            
        }
    }
}
