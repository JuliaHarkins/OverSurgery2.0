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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
            LoginController lc = LoginController.Instance();
            FormController fc = FormController.Instance();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginObserver lo = new LoginObserver();


            Dictionary<string, string> test = lo.LoginPassThrough(txt_Username.Text, txt_Password.Text);
            bool flg = LoginController.Instance().ValidateLogin(lo.LoginPassThrough(txt_Username.Text, txt_Password.Text));
            if (LoginController.Instance().ValidateLogin(lo.LoginPassThrough(txt_Username.Text, txt_Password.Text)))
            {
                Console.WriteLine("\t\tLOGGED IN");
                this.Hide();
                fc.SetCurrentUser(test["Username"]);
                fc.OpenMainForm();
                txt_Username.Clear();
                txt_Password.Clear();
                this.Show();
            }
            else
            {
                NonValidLogin();
            }
        }

        public void NonValidLogin()
        {
            MessageBox.Show("Invalid Login Details");
        }

        private void btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            fc.OpenForgotPasswordForm();
            this.Show();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginObserver lo = new LoginObserver();


                Dictionary<string, string> test = lo.LoginPassThrough(txt_Username.Text, txt_Password.Text);
                bool flg = LoginController.Instance().ValidateLogin(lo.LoginPassThrough(txt_Username.Text, txt_Password.Text));
                if (LoginController.Instance().ValidateLogin(lo.LoginPassThrough(txt_Username.Text, txt_Password.Text)))
                {
                    Console.WriteLine("\t\tLOGGED IN");
                    this.Hide();
                    fc.SetCurrentUser(test["Username"]);
                    fc.OpenMainForm();
                    txt_Username.Clear();
                    txt_Password.Clear();
                    this.Show();
                }
                else
                {
                    NonValidLogin();
                }
            }
        }
    }
}
