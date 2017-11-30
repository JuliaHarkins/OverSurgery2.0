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

namespace OverSurgery2
{
    public partial class MedicationForm : Form
    {
        MetaLayer ml = MetaLayer.Instance();
        List<Medication> medList = new List<Medication>();
        Medication med = null;
        int selectedMed = 0;

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
                medList = ml.GetMedicationByName(txtSearchMedName.Text);

                WriteBoxes();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("There were no medication found with that name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdateDosage.Clear();
                txtUpdateMedName.Clear();
                txtUpdatePermission.Clear();
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
                medList[selectedMed].Name = txtUpdateMedName.Text;

                // Verify the user wants to delete the medication
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + medList[selectedMed].Name + "?", "Delete Medication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ml.DeleteMedication(medList[selectedMed].ID);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ml.AddMedication(med);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
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
                ml.UpdateMedication(medList[selectedMed]);
            }
            catch(Exception ex)
            {
                throw ex;
                //MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    med = new Medication();
                    med.Name = txtAddMedName.Text;
                    med.PermissionLevel = Convert.ToUInt32(txtAddPermission.Text);
                    med.Dosage = txtAddDosage.Text;

                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateMed"])
                {
                    medList[selectedMed].Name = txtUpdateMedName.Text;
                    medList[selectedMed].PermissionLevel = Convert.ToUInt32(txtUpdatePermission.Text);
                    medList[selectedMed].Dosage = txtUpdateDosage.Text;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("An error occured. Make sure you are entering the appropriate values for the data required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtUpdateMedName.Text = medList[selectedMed].Name;
                    txtUpdatePermission.Text = Convert.ToString(medList[selectedMed].PermissionLevel);
                    txtUpdateDosage.Text = Convert.ToString(medList[selectedMed].Dosage);
                    updateButtons();
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                throw ex;
                //MessageBox.Show("An error has occured collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// Enable/Disable buttons depending on what medication dosage by name is selected
        /// </summary>
        private void updateButtons()
        {
            if (medList.Count == selectedMed+1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
            if(selectedMed == 0)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }
        }

        /// <summary>
        /// If multiple doses of medication are retrieved from the database cycle to the next one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            selectedMed++;
            WriteBoxes();
            updateButtons();
        }

        /// <summary>
        /// If multiple doses of medication are retrieved from the database cycle to the prev one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            selectedMed--;
            WriteBoxes();
            updateButtons();
        }
    }
}
