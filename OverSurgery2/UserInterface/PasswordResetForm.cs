using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery
{
    public partial class PasswordResetForm : Form
    {
        MetaLayer ml = MetaLayer.Instance();
        LoginController lc = LoginController.Instance();
        string m_currentUser;
        public PasswordResetForm(string user)
        {
            InitializeComponent();
            m_currentUser = user;
            this.ShowDialog();
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
