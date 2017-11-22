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
    public partial class MedicationForm : Form
    {
        private int m_medicationID, m_permissionLevel;
        private string m_medName, m_dosage;

        public MedicationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Search for an existing medication in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchMed_Click(object sender, EventArgs e)
        {
            
        }

        private void WriteBoxes()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddSMed"])
            {
                m_medName = txtAddMedName.Text;
                m_permissionLevel = Convert.ToInt32(txtAddPermission.Text);
                m_dosage = txtAddDosage.Text;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateMed"])
            {
                m_medName = txtUpdateMedName.Text;
                m_permissionLevel = Convert.ToInt32(txtUpdatePermission.Text);
                m_dosage = txtUpdateDosage.Text;
            }
            else
            {

            }
        }

        private void ReadBoxes()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddSMed"])
            {
                txtAddMedName.Text = m_medName;
                txtAddPermission.Text = Convert.ToString(m_permissionLevel);
                txtAddDosage.Text = m_dosage;

            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateMed"])
            {
                txtUpdateMedName.Text = m_medName;
                txtUpdatePermission.Text = Convert.ToString(m_permissionLevel);
                txtUpdateDosage.Text = m_dosage;
            }
            else
            {

            }
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
