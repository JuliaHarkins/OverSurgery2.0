namespace OverSurgery
{
    partial class PasswordResetForm
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
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.txt_VerifyPassword = new System.Windows.Forms.TextBox();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_PasswordGood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(112, 12);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_NewPassword.TabIndex = 0;
            // 
            // txt_VerifyPassword
            // 
            this.txt_VerifyPassword.Location = new System.Drawing.Point(112, 38);
            this.txt_VerifyPassword.Name = "txt_VerifyPassword";
            this.txt_VerifyPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_VerifyPassword.TabIndex = 1;
            this.txt_VerifyPassword.TextChanged += new System.EventHandler(this.txt_VerifyPassword_TextChanged);
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.Location = new System.Drawing.Point(189, 78);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(109, 23);
            this.btn_ResetPassword.TabIndex = 2;
            this.btn_ResetPassword.Text = "Reset Password";
            this.btn_ResetPassword.UseVisualStyleBackColor = true;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_ResetPassword_Click);
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(12, 15);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(78, 13);
            this.lbl_NewPassword.TabIndex = 3;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(12, 41);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lbl_ConfirmPassword.TabIndex = 4;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // lbl_PasswordGood
            // 
            this.lbl_PasswordGood.AutoSize = true;
            this.lbl_PasswordGood.Location = new System.Drawing.Point(218, 41);
            this.lbl_PasswordGood.Name = "lbl_PasswordGood";
            this.lbl_PasswordGood.Size = new System.Drawing.Size(0, 13);
            this.lbl_PasswordGood.TabIndex = 5;
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 111);
            this.Controls.Add(this.lbl_PasswordGood);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.btn_ResetPassword);
            this.Controls.Add(this.txt_VerifyPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Name = "PasswordResetForm";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.TextBox txt_VerifyPassword;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_PasswordGood;
    }
}