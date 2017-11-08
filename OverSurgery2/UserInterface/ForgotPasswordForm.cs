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
            lc.SendPasswordResetEmail(ml.GetStaffEmailByUserName(txt_UserName.Text), verification);
            ml.NewResetRequest(txt_UserName.Text, verification);
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            string user = txt_UserName.Text;
            if(lc.VerifyPasswordReset(user, txt_VerificationCode.Text))
            {
                this.Close();
                this.Dispose();
                fc.OpenPasswordResetForm(user);
            }
            else
            {
                MessageBox.Show("Invalid Verification Code");
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
