namespace OverSurgery
{
    partial class ForgotPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_VerificationCode = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_VerificationCode = new System.Windows.Forms.Label();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(105, 12);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_VerificationCode
            // 
            this.txt_VerificationCode.Location = new System.Drawing.Point(105, 64);
            this.txt_VerificationCode.Name = "txt_VerificationCode";
            this.txt_VerificationCode.Size = new System.Drawing.Size(100, 20);
            this.txt_VerificationCode.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(12, 15);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_VerificationCode
            // 
            this.lbl_VerificationCode.AutoSize = true;
            this.lbl_VerificationCode.Location = new System.Drawing.Point(12, 64);
            this.lbl_VerificationCode.Name = "lbl_VerificationCode";
            this.lbl_VerificationCode.Size = new System.Drawing.Size(87, 13);
            this.lbl_VerificationCode.TabIndex = 3;
            this.lbl_VerificationCode.Text = "Verification Code";
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Location = new System.Drawing.Point(116, 38);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(75, 23);
            this.btn_SendEmail.TabIndex = 4;
            this.btn_SendEmail.Text = "Send Email";
            this.btn_SendEmail.UseVisualStyleBackColor = true;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // btn_Verify
            // 
            this.btn_Verify.Location = new System.Drawing.Point(116, 90);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(75, 23);
            this.btn_Verify.TabIndex = 5;
            this.btn_Verify.Text = "Verify";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 123);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.btn_SendEmail);
            this.Controls.Add(this.lbl_VerificationCode);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_VerificationCode);
            this.Controls.Add(this.txt_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_VerificationCode;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_VerificationCode;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Button btn_Verify;
    }
}