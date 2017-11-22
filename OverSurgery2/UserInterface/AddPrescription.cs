using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2.UserInterface
{
    public partial class AddPrescription : Form
    {
        #region Members
        MetaLayer ml;
        MedicalStaff m_currentUser;
        List<Medication> m_medication;
#endregion
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            #region LoadMedication
            ml.getMedicationByLevel(m_currentUser.PrescriptionLevel);

            lst_medication.Columns.Add("Medication");
            lst_medication.Columns.Add("Dosage");
            lst_medication.Columns.Add("Permission Level");

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
