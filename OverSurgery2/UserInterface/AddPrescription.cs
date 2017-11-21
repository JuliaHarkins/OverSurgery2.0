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
    public partial class AddPrescription : Form
    {
        MedicalStaff m_currentUser;
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
#region GettingUser
            if (m_currentUser != null)
            {
                
            }
#endregion
        }

        private void btn_savePrescription_Click(object sender, EventArgs e)
        {

        }
    }
}
