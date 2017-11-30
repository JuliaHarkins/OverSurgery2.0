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
        private string m_userName;
        private uint m_addressID;

        Staff currentUserLoggedIn = null;                                                                                           // Details on the current user who is logged in
        Staff searchedStaff = new Staff();                                                                                                 // Searched staff members details
        MedicalStaff m = null;
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
                    searchedAddress = MetaLayer.Instance().GetAddressByID(Convert.ToInt32(searchedStaff.AddressID));
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
                WriteBoxes();
            }
            catch(Exception ex)
            {
                throw ex;
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
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            try
            {
                MetaLayer.Instance().UpdateAddress(searchedAddress, Convert.ToInt32(searchedStaff.AddressID));
            }
            catch(Exception ex)
            {
                throw ex;
            }
      
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
                
                // Check if staff is medical staff
                if (cboType.SelectedIndex != 3 || cboType.SelectedIndex !=4)
                {
                    m.AddressID = Convert.ToUInt16(MetaLayer.Instance().AddAddress(searchedAddress));
                    MetaLayer.Instance().AddMedicalStaff(m);
                }
                else
                {
                    searchedStaff.AddressID = Convert.ToUInt16(MetaLayer.Instance().AddAddress(searchedAddress));
                    MetaLayer.Instance().AddStaff(searchedStaff);
                }

                // clear all fields
                foreach(Control c in this.Controls)
                {
                    if(c is TextBox)
                    {
                        TextBox tb = c as TextBox;
                        if(tb.Text != String.Empty)
                        {
                            tb.Text = String.Empty;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
                //MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
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
                        m = new MedicalStaff()
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
                        searchedAddress.HouseName = txtAddHouseName.Text;
                        searchedAddress.HouseNumber = Convert.ToInt32(txtAddHouseNumber.Text);
                        searchedAddress.StreetName = txtAddAddressLine.Text;
                        searchedAddress.PostCode = txtAddPostCode.Text;
                    }
                    else
                    {
                        searchedStaff.EmailAddress = txtAddEmail.Text;
                        searchedStaff.Type = (int)cboType.SelectedIndex + 1;
                        searchedStaff.Password = LoginController.Instance().HashPassword(txtAddPassword.Text);
                        searchedAddress = new Address();
                        searchedAddress.HouseName = txtAddHouseName.Text;
                        searchedAddress.HouseNumber = Convert.ToInt32(txtAddHouseNumber.Text);
                        searchedAddress.StreetName = txtAddAddressLine.Text;
                        searchedAddress.PostCode = txtAddPostCode.Text;
                    }

                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    searchedStaff.Username = txtUpdateUserName.Text;
                    searchedStaff.Forename = txtUpdateForename.Text;
                    searchedStaff.Surname = txtUpdateSurname.Text;
                    //searchedStaff.Gender = Convert.ToInt32(cboUpdateGender.Text);
                    searchedStaff.EmailAddress = txtUpdateEmail.Text;
                    searchedStaff.Type = (int)cboUpdateType.SelectedValue + 1;
                    //searchedStaff.PhoneNumber = txtUpdatePhone.Text;

                    if (txtUpdatePostCode.Text.Length > 10)
                    {
                        MessageBox.Show("Postcode Too Long! Max 10 Characters!");
                    }
                    else
                    {
                        searchedAddress = new Address()
                        {
                            HouseName = txtUpdateHouseName.Text,
                            HouseNumber = Convert.ToInt32(txtUpdateHouseNumber.Text),
                            StreetName = txtUpdateAddressLine.Text,
                            PostCode = txtUpdatePostCode.Text
                        };
                    }
                    };
                }
                catch(Exception ex)
                {
                    throw ex;
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
                        MedicalStaff m = MetaLayer.Instance().GetMedicalStaffByStaffID(searchedStaff.StaffID, searchedStaff.Type) as MedicalStaff;
                        cboUpdateGender.SelectedIndex = (int)m.Gender;
                        cboUpdateGender.Enabled = true;
                        txtUpdatePhone.Enabled = true;
                        
                    }
                    txtUpdateUserName.Text = searchedStaff.Username;
                    txtUpdateForename.Text = searchedStaff.Forename;
                    txtUpdateSurname.Text = searchedStaff.Surname;
                    txtUpdateEmail.Text = searchedStaff.EmailAddress;
                    //txtUpdatePhone.Text = searchedStaff.PhoneNumber;
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
    }
}
