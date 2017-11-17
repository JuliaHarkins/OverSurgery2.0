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

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateRota_Click(object sender, EventArgs e)
        {

        }
    }
}
