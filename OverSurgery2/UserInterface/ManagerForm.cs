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
        BindingSource StaffBinding;
        BindingSource RotaBinding;
        Staff currentUserLoggedIn = null;
        public ManagerForm(Staff p_currentUser)
        {
            currentUserLoggedIn = p_currentUser;
            InitializeComponent();
            this.ShowDialog();
        }

        /// <summary>
        /// Update an existing staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {

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

        }

        /// <summary>
        /// Open the update rota form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateRota_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
