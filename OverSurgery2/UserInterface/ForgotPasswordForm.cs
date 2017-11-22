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
        FormController fc;
        LoginController lc;
        MetaLayer ml;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            fc = FormController.Instance();
            ml = MetaLayer.Instance();
            lc = LoginController.Instance();
            btn_Verify.Enabled = false; ;
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            string verification = lc.GenerateVerification(8);
            
            if(ml.NewResetRequest(txt_UserName.Text, verification))
            {
                lc.SendPasswordResetEmail(ml.GetStaffEmailByUserName(txt_UserName.Text), verification);
                btn_Verify.Enabled = true;
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
