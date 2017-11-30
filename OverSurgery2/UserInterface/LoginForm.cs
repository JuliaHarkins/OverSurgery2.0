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
        LoginController lc;
        FormController fc;
        public LoginForm()
        {
            InitializeComponent();
            fc = FormController.Instance();
            lc = LoginController.Instance();

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {

            SendLogin();            
        }

        private void SendLogin()
        {
            LoginObserver lo = new LoginObserver();
            bool flg = LoginController.Instance().ValidateLogin(lo.LoginPassThrough(txt_Username.Text, txt_Password.Text));
            if (flg)
            {
                this.Hide();
                fc.SetCurrentUser(LoginController.Instance().LoginDetails["Username"]);
                Logger.GetLogger().AddLog(new LoggerEvent(DateTime.Now, LogType.Login, LoginController.Instance().LoginDetails["Username"], "Logged in"));
                fc.OpenMainForm();
                txt_Username.Clear();
                txt_Password.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Details, please try again");
            }
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
                SendLogin();
            }
        }
    }
}
