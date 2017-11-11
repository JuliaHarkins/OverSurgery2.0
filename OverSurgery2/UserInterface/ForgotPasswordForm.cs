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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            string verification = Singletons.lc.GenerateVerification(8);
            
            if(Singletons.ml.NewResetRequest(txt_UserName.Text, verification))
            {
                Singletons.lc.SendPasswordResetEmail(Singletons.ml.GetStaffEmailByUserName(txt_UserName.Text), verification);
            }
            else
            {
                MessageBox.Show("Reset Request Unsuccessful, please see your manager");
            }
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            Staff user = Singletons.ml.GetStaffByUserName(txt_UserName.Text);
            if(Singletons.lc.VerifyPasswordReset(user, txt_VerificationCode.Text))
            {
                this.Close();
                this.Dispose();
                Singletons.fc.OpenPasswordResetForm(user);
            }
            else
            {
                MessageBox.Show("Invalid Verification Code, please try again");
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
