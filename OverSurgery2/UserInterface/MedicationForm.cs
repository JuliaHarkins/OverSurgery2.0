/* Created by: R
 * First Created: 22/11/17
 * Last Edit: 22/11/17 16:22
 * Last Edit by: R
 */
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
        private uint m_medicationID, m_permissionLevel, m_dosage;
        private string m_medName;
        MetaLayer ml = MetaLayer.Instance();
        Medication med = null;

        public MedicationForm()
        {
            InitializeComponent();
        }

        private void btnRemoveMed_MouseHover(object sender, EventArgs e)
        {
            ToolTip deleteonadd = new ToolTip();
            deleteonadd.SetToolTip(btnRemoveMed, "This will delete the medication currently being displayed");
        }

        /// <summary>
        /// Search for an existing medication in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchMed_Click(object sender, EventArgs e)
        {
            try
            {
                med.Name = txtSearchMedName.Text;
                ml.GetMedicationByName(med.Name);

                WriteBoxes();
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        /// <summary>
        /// Remove medication from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveMed_Click(object sender, EventArgs e)
        {
            try
            {
                med.Name = txtUpdateMedName.Text;

                // Verify the user wants to delete the medication
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + m_medName + "?", "Delete Medication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ml.DeleteMedication(med.Name);
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
        /// <summary>
        /// Add a new medication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMed_Click(object sender, EventArgs e)
        {
            try
            {
                ReadBoxes();
                //ml.AddMedication();
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Update a medications details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateMed_Click(object sender, EventArgs e)
        {
            try
            {
                ReadBoxes();
                //ml.UpdateMedication();
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Open the rota form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateRota_Click(object sender, EventArgs e)
        {
            RotaForm r = new RotaForm();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Write the text boxes values into the variables
        /// </summary>
        private void ReadBoxes()
        {
            try
            {
                //Check the tab the user is currently in
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddMed"])
                {
                    txtAddMedName.Text = med.Name;
                    txtAddPermission.Text = Convert.ToString(med.PermissionLevel);
                    txtAddDosage.Text = Convert.ToString(med.Dosage);

                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateMed"])
                {
                    txtUpdateMedName.Text = med.Name;
                    txtUpdatePermission.Text = Convert.ToString(med.PermissionLevel);
                    txtUpdateDosage.Text = Convert.ToString(med.Dosage);
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("An error occured. Make sure you are entering the appropriate values for the data required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Write the values in the variables into the text boxes
        /// </summary>
        private void WriteBoxes()
        {
            try
            {
                //Check the tab the user is currently in
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddMed"])
                {
                    tabControl1.SelectedTab = tabUpdateMed;
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateMed"])
                {
                    med.Name = txtUpdateMedName.Text;
                    med.PermissionLevel = Convert.ToUInt32(txtUpdatePermission.Text);
                    med.Dosage = txtUpdateDosage.Text;
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("An error has occured collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
