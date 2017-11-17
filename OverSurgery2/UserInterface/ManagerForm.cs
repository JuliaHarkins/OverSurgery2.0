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
        private string m_userName;
        private int m_staffID;
        private string m_forename;
        private string m_surname;
        private int m_practiceNumber;
        private int m_Gender;
        private string m_email;
        private int m_type;
        private string m_password;
        private string m_phone;
        private int m_addressID;
        
        BindingSource StaffBinding;
        BindingSource RotaBinding;
        Staff currentUserLoggedIn = null;
        MetaLayer ml;
        public ManagerForm(Staff p_currentUser)
        {
            currentUserLoggedIn = p_currentUser;
            
            InitializeComponent();
            this.ShowDialog();

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

        }

        /// <summary>
        /// Update an existing staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            //ml.UpdateStaffMember();
        }

        /// <summary>
        /// Add a new staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Remove a staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            m_userName = txtUserName.Text;
            ml.DeleteStaff(m_userName);
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

        }

    }
}
