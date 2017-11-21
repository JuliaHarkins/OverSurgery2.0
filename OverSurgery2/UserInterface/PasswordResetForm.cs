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
    public partial class PasswordResetForm : Form
    {
        Staff m_currentUser;
        MetaLayer ml;
        LoginController lc;
        public PasswordResetForm(Staff p_Staff)
        {
            InitializeComponent();
            m_currentUser = p_Staff;
            ml = MetaLayer.Instance();
            lc = LoginController.Instance();
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            if (txt_NewPassword.Text == txt_VerifyPassword.Text)
            {
                if(ml.UpdateStaffPassword(m_currentUser, lc.HashPassword(txt_VerifyPassword.Text)))
                {
                    MessageBox.Show("Password Reset!");
                }
            }
            else
            {
                Console.WriteLine("Notworking");
            }
            this.Close();
            this.Dispose();
        }

        private void txt_VerifyPassword_TextChanged(object sender, EventArgs e)
        {
            if(txt_VerifyPassword.Text != txt_NewPassword.Text && txt_NewPassword.Text != null)
            {
                lbl_PasswordGood.Text = "\u2718";
            }
            else
            {
                lbl_PasswordGood.Text = "\u2713";
            }
        }
    }
}
