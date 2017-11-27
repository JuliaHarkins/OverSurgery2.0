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
using OverSurgery2.UserInterface;

namespace OverSurgery2
{
    public partial class ManagerForm : Form
    {
        private string m_userName, m_forename, m_surname, m_email, m_password, m_phone, m_houseName, m_addressLine, m_postCode;
        private int m_staffID, m_practiceNumber, m_Gender, m_type, m_houseNumber;
        private uint m_addressID;

        Staff currentUserLoggedIn = null;                                                                                           // Details on the current user who is logged in
        Staff searchedStaff = null;                                                                                                 // Searched staff members details
        Address searchedAddress = null;                                                                                             // Searched staff members address details
        MetaLayer ml;
        BindingSource StaffBinding;
        BindingSource RotaBinding;   

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            //Set combo box values
            cboType.DataSource = Enum.GetValues(typeof(StaffTypes));
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
            // Disable fields according to selected type
            if ((cboType.Text == "1") || (cboType.Text == "2") || (cboType.Text == "3"))
            {
                txtAddPhone.Enabled = true;
                cboAddGender.Enabled = true;
            }
            else
            {
                txtAddPhone.Enabled = false;
                cboAddGender.Enabled = false;
            }

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
                // Collect data from the metalayer and store it inside the form
                searchedStaff = MetaLayer.Instance().GetStaffByUserName(txtSearchUserName.Text);
                searchedAddress = MetaLayer.Instance().GetAddressByID(Convert.ToInt32(searchedStaff.AddressID));
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
            catch
            {
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
                MetaLayer.Instance().UpdateAddress(searchedAddress);    
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ml.AddStaff(searchedStaff);
                ml.AddAddress(searchedAddress);
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //ReadBoxes();
                m_userName = txtUpdateUserName.Text;
                m_addressID = Convert.ToUInt32(searchedStaff.AddressID);

                // Verify the user wants to delete the staff member
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + m_userName + "?", "Delete Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MetaLayer.Instance().DeleteStaff(m_userName);
                    MetaLayer.Instance().DeleteAddress(Convert.ToInt32(m_addressID));
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
                    searchedStaff.Username = txtAddUserName.Text;
                    searchedStaff.Forename = txtAddForename.Text;
                    searchedStaff.Surname = txtAddSurname.Text;
                    //searchedStaff.PracticeNumber = Convert.ToInt32(txtPracticeNumberAdd.Text);
                    //searchedStaff.Gender = Convert.ToInt32(cboAddGender.Text);
                    searchedStaff.EmailAddress = txtAddEmail.Text;
                    searchedStaff.Type = Convert.ToInt32(cboType.Text);
                    searchedStaff.Password = txtAddPassword.Text;
                    //searchedStaff.PhoneNumber = txtAddPhone.Text;
                    searchedAddress.HouseName = txtAddHouseName.Text;
                    searchedAddress.HouseNumber = Convert.ToInt32(txtAddHouseNumber.Text);
                    searchedAddress.StreetName = txtAddAddressLine.Text;
                    searchedAddress.PostCode = txtAddPostCode.Text;
                    
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    searchedStaff.Username = txtUpdateUserName.Text;
                    searchedStaff.Forename = txtUpdateForename.Text;
                    searchedStaff.Surname = txtUpdateSurname.Text;
                    //searchedStaff.Gender = Convert.ToInt32(cboUpdateGender.Text);
                    searchedStaff.EmailAddress = txtUpdateEmail.Text;
                    //searchedStaff.PhoneNumber = txtUpdatePhone.Text;
                    searchedAddress.HouseName = txtUpdateHouseName.Text;
                    searchedAddress.HouseNumber = Convert.ToInt32(txtUpdateHouseNumber.Text);
                    searchedAddress.StreetName = txtUpdateAddressLine.Text;
                    searchedAddress.PostCode = txtUpdatePostCode.Text;
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
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    txtUpdateUserName.Text = searchedStaff.Username;
                    txtUpdateForename.Text = searchedStaff.Forename;
                    txtUpdateSurname.Text = searchedStaff.Surname;
                    txtUpdateEmail.Text = searchedStaff.EmailAddress;
                    //cboUpdateGender.Text = searchedStaff.Gender;
                    //txtUpdatePhone.Text = searchedStaff.PhoneNumber;
                    txtUpdateHouseName.Text = searchedAddress.HouseName;
                    txtUpdateHouseNumber.Text = Convert.ToString(searchedAddress.HouseNumber);
                    txtUpdatePostCode.Text = searchedAddress.PostCode;
                    txtUpdateAddressLine.Text = searchedAddress.StreetName;
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
