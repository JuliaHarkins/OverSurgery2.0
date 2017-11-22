/* Created by: J
 * First Created: 31/10/17
 * Last Edit: 14/11/17 16:22
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
        private string m_userName, m_forename, m_surname, m_email, m_password, m_phone, m_houseName, m_addressLine, m_postCode;
        private int m_staffID, m_practiceNumber, m_Gender, m_type, m_addressID, m_houseNumber;

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        BindingSource StaffBinding;
        BindingSource RotaBinding;
        Staff currentUserLoggedIn = null;
        MetaLayer ml;

        public ManagerForm(Staff p_currentUser)
        {
            currentUserLoggedIn = p_currentUser;
            
            InitializeComponent();
            this.ShowDialog();

            ToolTip type = new ToolTip();
            type.SetToolTip(this.cboType, "1=MedStaff 2=Locum 3=Doctor 4=Receptionist 5=Manager");

            ToolTip deleteonadd = new ToolTip();
            deleteonadd.SetToolTip(btnRemoveStaff2, "This will delete the staff member from the database");

            ToolTip deleteonupdate = new ToolTip();
            deleteonupdate.SetToolTip(btnRemoveStaff, "This will delete the staff member from the database");

            // Disable fields according to selected type
            if ((cboType.Text == "1") || (cboType.Text == "2") || (cboType.Text == "3"))
            {
                txtAddPhone.Enabled = true;
                txtAddGender.Enabled = true;
            }
            else
            {
                txtAddPhone.Enabled = false;
                txtAddGender.Enabled = false;
            }

        }

        /// <summary>
        /// Search for member of staffs username and retrieve details on that staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchUserName_Click(object sender, EventArgs e)
        {
            m_userName = txtSearchUserName.Text;
            ml.GetStaffByUserName(m_userName);

            //update addressID variable before entering the method below
            ml.GetAddressByID(m_addressID);

            WriteBoxes();
        }

        /// <summary>
        /// Update an existing staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            ReadBoxes();
            //ml.UpdateStaffMember(Staff staffMember);
            //ml.UpdateAddress(Address staffAddress);          
        }

        /// <summary>
        /// Add a new staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            ReadBoxes();

            // Add new data to staff
            Staff staff = new Staff();
            staff.AddressID = null;
            staff.Forename = m_forename;
            staff.Surname = m_surname;
            staff.Username = m_userName;
            staff.Password = m_password;
            ml.AddStaff(staff);

            // Add new data to address
            Address address = new Address();
            address.HouseName = m_houseName;
            address.HouseNumber = m_houseNumber;
            address.StreetName = m_addressLine;
            address.PostCode = m_postCode;
            ml.AddAddress(address);
        }

        /// <summary>
        /// Remove a staff member from Update form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            removeStaffMember();
        }

        /// <summary>
        /// Remove a staff member from Add form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStaff2_Click(object sender, EventArgs e)
        {
            removeStaffMember();
        }

        /// <summary>
        /// Remove a staff member from the database
        /// </summary>
        public void removeStaffMember()
        {
            ReadBoxes();
            m_userName = txtSearchUserName.Text;

            // Verify the user wants to delete the staff member
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + m_userName + "?", "Delete Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ml.DeleteStaff(m_userName);
                ml.DeleteAddress(m_addressID);
            }
            else
            {

            }
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
                    m_userName = txtAddUserName.Text;
                    m_forename = txtAddForename.Text;
                    m_surname = txtAddSurname.Text;
                    m_practiceNumber = Convert.ToInt32(txtPracticeNumberAdd.Text);
                    m_Gender = Convert.ToInt32(txtAddGender.Text);
                    m_email = txtAddEmail.Text;
                    m_type = Convert.ToInt32(cboType.Text);
                    m_password = txtAddPassword.Text;
                    m_phone = txtAddPhone.Text;
                    m_houseName = txtAddHouseName.Text;
                    m_houseNumber = Convert.ToInt32(txtAddHouseNumber.Text);
                    m_addressLine = txtAddAddressLine.Text;
                    m_postCode = txtAddPostCode.Text;
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    m_userName = txtUpdateUserName.Text;
                    m_forename = txtUpdateForename.Text;
                    m_surname = txtUpdateSurname.Text;
                    m_Gender = Convert.ToInt32(txtUpdateGender.Text);
                    m_email = txtUpdateEmail.Text;
                    m_password = txtUpdatePassword.Text;
                    m_phone = txtUpdatePhone.Text;
                    m_houseName = txtUpdateHouseName.Text;
                    m_houseNumber = Convert.ToInt32(txtUpdateHouseNumber.Text);
                    m_addressLine = txtUpdateAddressLine.Text;
                    m_postCode = txtUpdatePostCode.Text;
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddMedication"])
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
                    txtAddUserName.Text = m_userName;
                    txtAddForename.Text = m_forename;
                    txtAddSurname.Text = m_surname;
                    txtPracticeNumberAdd.Text = Convert.ToString(m_practiceNumber);
                    txtAddGender.Text = Convert.ToString(m_Gender);
                    txtAddEmail.Text = m_email;
                    cboType.Text = Convert.ToString(m_type);
                    txtAddPassword.Text = m_password;
                    txtAddPhone.Text = m_phone;
                    txtAddHouseName.Text = m_houseName;
                    txtAddHouseNumber.Text = Convert.ToString(m_houseNumber);
                    txtAddAddressLine.Text = m_addressLine;
                    txtAddPostCode.Text = m_postCode;
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabUpdateStaff"])
                {
                    txtUpdateUserName.Text = m_userName;
                    txtUpdateForename.Text = m_forename;
                    txtUpdateSurname.Text = m_surname;
                    txtUpdateGender.Text = Convert.ToString(m_Gender);
                    txtUpdateEmail.Text = m_email;
                    txtUpdatePassword.Text = m_password;
                    txtUpdatePhone.Text = m_phone;
                    txtUpdateHouseName.Text = m_houseName;
                    txtUpdateHouseNumber.Text = Convert.ToString(m_houseNumber);
                    txtUpdateAddressLine.Text = m_addressLine;
                    txtUpdatePostCode.Text = m_postCode;
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabAddMedication"]) 
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
