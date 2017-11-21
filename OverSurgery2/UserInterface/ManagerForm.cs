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

        BindingSource StaffBinding;
        BindingSource RotaBinding;
        Staff currentUserLoggedIn = null;
        MetaLayer ml;
        public ManagerForm(Staff p_currentUser)
        {
            currentUserLoggedIn = p_currentUser;
            
            InitializeComponent();
            this.ShowDialog();
            ToolTip t = new ToolTip();
            t.SetToolTip(this.cboType, "1=MedStaff 2=Locum 3=Doctor 4=Receptionist 5=Manager");

            // Update helper label to inform user about type choices
            if (Convert.ToInt32(cboType.Text) == 1)
            {
                lblTypeHelper.Text = "Medical Staff";
            }
            else if (Convert.ToInt32(cboType.Text) == 2)
            {
                lblTypeHelper.Text = "Locum";
            }
            else if (Convert.ToInt32(cboType.Text) == 3)
            {
                lblTypeHelper.Text = "Doctor";
            }
            else if (Convert.ToInt32(cboType.Text) == 4)
            {
                lblTypeHelper.Text = "Receptionist";
            }
            else if (Convert.ToInt32(cboType.Text) == 5)
            {     
                lblTypeHelper.Text = "Manager";
            }
            else
            {
                lblTypeHelper.Text = "";
            }

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
        }

        /// <summary>
        /// Remove a staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            ReadBoxes();
            m_userName = txtUserName.Text;
            ml.DeleteStaff(m_userName);
            ml.DeleteAddress(m_addressID);
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
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Search for member of staffs username and retrieve details on that staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchUserName_Click(object sender, EventArgs e)
        {
            m_userName = txtUserName.Text;
            ml.GetStaffByUserName(m_userName);
            
            //update addressID variable before entering the method below
            ml.GetAddressByID(m_addressID);

            WriteBoxes();
        }

        /// <summary>
        /// Reads values the user has entered from the text boxes into variables
        /// </summary>
        private void ReadBoxes()
        {
            try
            {
                m_userName = txtUserName.Text;
                m_forename = txtForename.Text;
                m_surname = txtSurname.Text;
                m_practiceNumber = Convert.ToInt32(txtPracticeNumber.Text);
                m_Gender = Convert.ToInt32(txtGender.Text);
                m_email = txtEmail.Text;
                m_type = Convert.ToInt32(cboType.Text);
                m_password = txtPassword.Text;
                m_phone = txtPhone.Text;
                m_addressID = Convert.ToInt32(txtAddress.Text);
                m_houseName = txtHouseName.Text;
                m_houseNumber = Convert.ToInt32(txtHouseNumber.Text);
                m_addressLine = txtAddressLine.Text;
                m_postCode = txtPostCode.Text;
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
                txtUserName.Text = m_userName;
                txtForename.Text= m_forename;
                txtSurname.Text = m_surname;
                txtPracticeNumber.Text = Convert.ToString(m_practiceNumber);
                txtGender.Text = Convert.ToString(m_Gender);
                txtEmail.Text = m_email;
                cboType.Text = Convert.ToString(m_type);
                txtPassword.Text = m_password;
                txtPhone.Text = m_phone;
                txtAddress.Text = Convert.ToString(m_addressID);
                txtHouseName.Text = m_houseName;
                txtHouseNumber.Text = Convert.ToString(m_houseNumber);
                txtAddressLine.Text = m_addressLine;
                txtPostCode.Text = m_postCode;
            }
            catch
            {
                MessageBox.Show("An error has occured collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
