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
        MetaLayer ml = MetaLayer.Instance();
        LoginController lc = LoginController.Instance();
        FormController fc = FormController.Instance();
        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            string verification = lc.GenerateVerification(8);
            
            if(ml.NewResetRequest(txt_UserName.Text, verification))
            {
                lc.SendPasswordResetEmail(ml.GetStaffEmailByUserName(txt_UserName.Text), verification);
            }
            else
            {
                MessageBox.Show("Reset Request Unsuccessful, please see your manager");
            }
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            Staff user = ml.GetStaffByUserName(txt_UserName.Text);
            if(lc.VerifyPasswordReset(user, txt_VerificationCode.Text))
            {
                this.Close();
                this.Dispose();
                fc.OpenPasswordResetForm(user);
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
