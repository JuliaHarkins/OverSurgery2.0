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
        int  m_patientID;
#endregion
        public AddPrescription(Staff p_currentUser, int p_patientID)
        {
            m_currentUser = p_currentUser as MedicalStaff;
            m_patientID = p_patientID;
            m_medication = ml.getMedicationOnMedStaffID(m_currentUser.MedicalStaffID);
            InitializeComponent();

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            #region LoadMedication
            lst_medication.Columns.Add("Medication", 75);
            lst_medication.Columns.Add("Dosage", 75);
            lst_medication.Columns.Add("Permission Level",91);

            foreach (Medication m in m_medication)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.Name.ToString();
                lvi.SubItems.Add(m.Dosage.ToString());
                lvi.SubItems.Add(m.PermissionLevel.ToString());
                lst_medication.Items.Add(lvi);
            }

            #endregion

        }

        private void btn_savePrescription_Click(object sender, EventArgs e)
        {

        }

        private void btn_medicationSearch_Click(object sender, EventArgs e)
        {

        }

        private void lst_medication_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
