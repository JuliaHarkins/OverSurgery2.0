/* Created by: J
 * First Created: 31/10/17
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
    public partial class ManagerForm : Form
    {
        private string m_userName, column, passedData;
        private uint m_addressID;
        bool flag = true;

        Staff currentUserLoggedIn = null;                                                                                           // Details on the current user who is logged in
        Staff searchedStaff = new Staff();                                                                                          // Searched staff members details
        MedicalStaff newMedicalStaff = null;
        Address searchedAddress = null;                                                                                             // Searched staff members address details  

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            //Set combo box values
            cboType.DataSource = Enum.GetValues(typeof(StaffTypes));
            cboUpdateType.DataSource = Enum.GetValues(typeof(StaffTypes));
            cboAddGender.Items.Add("Female");
            cboAddGender.Items.Add("Male");
            cboUpdateGender.Items.Add("Female");
            cboUpdateGender.Items.Add("Male");
        }

        enum StaffTypes { Nurse, Locum, Doctor, Receptionist, Manager };

        /// <summary>
        /// Tool tip for remove staff button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStaff_MouseHover(object sender, EventArgs e)
        {
            ToolTip deleteonupdate = new ToolTip();
            deleteonupdate.SetToolTip(btnRemoveStaff, "This will delete the staff member currently being displayed");
        }       

        public ManagerForm(Staff p_currentUser)
        {
            currentUserLoggedIn = p_currentUser;       
            InitializeComponent();
        }

        /// <summary>
        /// Search for member of staffs username and retrieve details on that staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchUserName_Click(object sender, EventArgs e)
        { 
            if (txtSearchUserName.Text != "")
            {
                try
                {
                    // Collect data from the metalayer and store it inside the form
                    searchedStaff = MetaLayer.Instance().GetStaffByUserName(txtSearchUserName.Text);
                    searchedAddress = MetaLayer.Instance().GetAddressById(Convert.ToInt32(searchedStaff.AddressID));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // Change the selected tab to the update tab
            if (searchedStaff != null)
            {
                tabControl1.SelectedTab = tabUpdateStaff;
            }

            // Update text boxes with new information
            try
            {
                // If the staff member is not a medical staff clear the fields that are not being updated
                if (searchedStaff.Type == 4 || searchedStaff.Type == 5)
                {
                    txtUpdatePhone.Text = "";
                    cboUpdateGender.Text = "";
                }

                WriteBoxes();
            }
            catch(Exception ex)
            {
                //throw ex;
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Update an existing staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                ReadBoxes();
                MetaLayer.Instance().UpdateStaffMember(searchedStaff);
                flag = true;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            try
            {
                MetaLayer.Instance().UpdateAddress(searchedAddress, Convert.ToInt32(searchedStaff.AddressID));
                flag = true;
            }
            catch(Exception ex)
            {
                //throw ex;
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (flag)
            {
                MessageBox.Show("Staff Updated", "Updated Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearBoxes();

        }

        /// <summary>
        /// Add a new staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                ReadBoxes();

                if(searchedAddress.HouseName == null && searchedAddress.HouseNumber == 0)
                {
                    throw new Exception("Both the house number and house name textboxes are blank");
                }

                // Build the database query to send to the metalayer
                if (searchedAddress.HouseName != null && searchedAddress.HouseNumber == 0)
                {
                    column = $" (AddressID, HouseName, AddressLine1, PostCode)";
                    passedData = $"null, '{searchedAddress.HouseName}', '{searchedAddress.StreetName}', '{searchedAddress.PostCode}'";
                }
                else if (searchedAddress.HouseNumber != 0 && searchedAddress.HouseName == null)
                {
                    column = $" (AddressID, HouseNumber, AddressLine1, PostCode)";
                    passedData = $"null, {searchedAddress.HouseNumber}, '{searchedAddress.StreetName}', '{searchedAddress.PostCode}'";
                }
                else
                {
                    column = null;
                    passedData = $"null, '{searchedAddress.HouseName}', {searchedAddress.HouseNumber}, '{searchedAddress.StreetName}', '{searchedAddress.PostCode}'";
                }

                // Check if staff is medical staff
                if (cboType.SelectedIndex != 3 || cboType.SelectedIndex !=4)
                {
                    newMedicalStaff.AddressID = Convert.ToUInt16(MetaLayer.Instance().AddAddress(searchedAddress, column, passedData));
                    
                    MetaLayer.Instance().AddMedicalStaff(newMedicalStaff);
                    flag = true;
                }
                else
                {
                    searchedStaff.AddressID = Convert.ToUInt16(MetaLayer.Instance().AddAddress(searchedAddress, column, passedData));
                    MetaLayer.Instance().AddStaff(searchedStaff);
                    flag = true;
                }

            }
            catch(Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (flag == true)
            {
                MessageBox.Show("Staff Added", "New Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearBoxes();
        }

        /// <summary>
        /// Remove a staff member from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {  
            try
            {

                // Verify the user wants to delete the staff member
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + m_userName + "?", "Delete Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the staff memeber along with and medical staff entries
                    MetaLayer.Instance().DeleteStaff(searchedStaff);
                    flag = true;
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                //throw ex;
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (flag == true)
            {
                MessageBox.Show("Staff Deleted", "Removed Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearBoxes();

        }

        /// <summary>
        /// Open the medication form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            MedicationForm m = new MedicationForm();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Open the update rota form
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
        /// Reads values the user has entered from the text boxes into variables
        /// </summary>
        private void ReadBoxes()
        {
            try
            {
                //check the tab the user is currently in
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddStaff"])
                {
                    searchedStaff = new Staff();
                    searchedStaff.Username = txtAddUserName.Text;
                    searchedStaff.Forename = txtAddForename.Text;
                    searchedStaff.Surname = txtAddSurname.Text;
                    
                    // Check to see if the staff member is a medical staff member
                    if ((int)cboType.SelectedIndex == 0 || (int)cboType.SelectedIndex == 1 || (int)cboType.SelectedIndex == 2)
                    {
                        newMedicalStaff = new MedicalStaff()
                        {
                            Username = txtAddUserName.Text,
                            Forename = txtAddForename.Text,
                            Surname = txtAddSurname.Text,
                            Gender = (uint)cboAddGender.SelectedIndex,
                            Password = LoginController.Instance().HashPassword(txtAddPassword.Text),
                            PhoneNumber = txtAddPhone.Text,
                            PracticeNumber = txtPracticeNumberAdd.Text,
                            EmailAddress = txtAddEmail.Text,
                            Type = (int)cboType.SelectedIndex + 1
                        };

                        searchedAddress = new Address();
                        searchedAddress.HouseName = txtAddHouseName.Text.Equals("") ? null : txtAddHouseName.Text;
                        searchedAddress.HouseNumber = Convert.ToInt32(txtAddHouseNumber.Text.Equals("") ? "0" : txtAddHouseNumber.Text);
                        searchedAddress.StreetName = txtAddAddressLine.Text;
                        searchedAddress.PostCode = txtAddPostCode.Text;
                    }
                    else
                    {
                        searchedStaff.EmailAddress = txtAddEmail.Text;
                        searchedStaff.Type = (int)cboType.SelectedIndex + 1;
                        searchedStaff.Password = LoginController.Instance().HashPassword(txtAddPassword.Text);
                        searchedAddress = new Address();
                        searchedAddress.HouseName = txtAddHouseName.Text.Equals("") ? null : txtAddHouseName.Text;
                        searchedAddress.HouseNumber = Convert.ToInt32(txtAddHouseNumber.Text.Equals("") ? "0" : txtAddHouseNumber.Text);
                        searchedAddress.StreetName = txtAddAddressLine.Text;
                        searchedAddress.PostCode = txtAddPostCode.Text;
                    }

                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    searchedStaff.Username = txtUpdateUserName.Text;
                    searchedStaff.Forename = txtUpdateForename.Text;
                    searchedStaff.Surname = txtUpdateSurname.Text;
                    searchedStaff.EmailAddress = txtUpdateEmail.Text;
                    searchedStaff.Type = (int)cboUpdateType.SelectedValue + 1;
                    
                    if (txtUpdatePostCode.Text.Length > 10)
                    {
                        MessageBox.Show("Postcode Too Long! Max 10 Characters!");
                    }
                    else
                    {
                        searchedAddress = new Address()
                        {
                            HouseName = txtUpdateHouseName.Text.Equals("") ? null : txtAddHouseName.Text,
                            HouseNumber = Convert.ToInt32(txtUpdateHouseNumber.Text.Equals("") ? "0" : txtUpdateHouseNumber.Text),
                            StreetName = txtUpdateAddressLine.Text,
                            PostCode = txtUpdatePostCode.Text
                        };
                    }
                }
            }
            catch(Exception ex)
            {
                //throw ex;
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Write new values into text boxes
        /// </summary>
        private void WriteBoxes()
        {
            try
            {
                //check the tab the user is currently in
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddStaff"])
                {
                    tabControl1.SelectedTab = tabUpdateStaff;
                    txtUpdatePhone.Enabled = false;
                    cboUpdateGender.Enabled = false;
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    txtUpdatePhone.Enabled = false;
                    cboUpdateGender.Enabled = false;
                    if (searchedStaff.Type == 1||searchedStaff.Type==2||searchedStaff.Type==3)
                    {
                        MedicalStaff newMedicalStaff = MetaLayer.Instance().GetMedicalStaffByStaffID(searchedStaff.StaffID, searchedStaff.Type) as MedicalStaff;
                        cboUpdateGender.Enabled = true;
                        txtUpdatePhone.Enabled = true;
                        cboUpdateGender.Text = cboUpdateGender.Items[Convert.ToInt32(newMedicalStaff.Gender)].ToString();
                        txtUpdatePhone.Text = newMedicalStaff.PhoneNumber;
                        
                    }
                    txtUpdateUserName.Text = searchedStaff.Username;
                    txtUpdateForename.Text = searchedStaff.Forename;
                    txtUpdateSurname.Text = searchedStaff.Surname;
                    txtUpdateEmail.Text = searchedStaff.EmailAddress;
                    txtUpdateHouseName.Text = searchedAddress.HouseName;
                    txtUpdateHouseNumber.Text = Convert.ToString(searchedAddress.HouseNumber);
                    txtUpdatePostCode.Text = searchedAddress.PostCode;
                    txtUpdateAddressLine.Text = searchedAddress.StreetName;
                    cboUpdateType.SelectedIndex = searchedStaff.Type - 1;
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// Enable/disable fields depending on type of staff selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((int)cboType.SelectedValue == 3) || ((int)cboType.SelectedValue == 4))
            {
                txtAddPhone.Enabled = false;
                cboAddGender.Enabled = false;
            }
            else
            {
                txtAddPhone.Enabled = true;
                cboAddGender.Enabled = true;
            }
        }

        /// <summary>
        /// Clear all the text boxes on the form
        /// </summary>
        private void ClearBoxes()
        {
            btnSearchUserName.Text = "";

            // Clear add tab fields
            txtAddUserName.Text = "";
            txtAddPassword.Text = "";
            txtAddForename.Text = "";
            txtAddSurname.Text = "";
            txtAddPhone.Text = "";
            txtAddEmail.Text = "";
            txtPracticeNumberAdd.Text = "";
            txtAddHouseName.Text = "";
            txtAddHouseNumber.Text = "";
            txtAddAddressLine.Text = "";
            txtAddPostCode.Text = "";
            cboAddGender.Text = "";

            // Clear update tab fields
            txtUpdateUserName.Text = "";
            txtUpdateForename.Text = "";
            txtUpdateSurname.Text = "";
            txtUpdatePhone.Text = "";
            txtUpdateEmail.Text = "";
            txtUpdateHouseName.Text = "";
            txtUpdateHouseNumber.Text = "";
            txtUpdateAddressLine.Text = "";
            txtUpdatePostCode.Text = "";
            cboUpdateGender.Text = "";
        }
    }
}
