namespace OverSurgery2
{
    partial class LoginForm
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
            this.lbl_OverTitle = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_ForgotPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_OverTitle
            // 
            this.lbl_OverTitle.AutoSize = true;
            this.lbl_OverTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OverTitle.Location = new System.Drawing.Point(18, 9);
            this.lbl_OverTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OverTitle.Name = "lbl_OverTitle";
            this.lbl_OverTitle.Size = new System.Drawing.Size(231, 25);
            this.lbl_OverTitle.TabIndex = 0;
            this.lbl_OverTitle.Text = "Over Surgery - Login";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(105, 75);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(188, 26);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(105, 39);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(188, 26);
            this.txt_Username.TabIndex = 1;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(14, 42);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(83, 20);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(19, 78);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(181, 111);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 35);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_ForgotPassword
            // 
            this.btn_ForgotPassword.Location = new System.Drawing.Point(13, 111);
            this.btn_ForgotPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ForgotPassword.Name = "btn_ForgotPassword";
            this.btn_ForgotPassword.Size = new System.Drawing.Size(160, 35);
            this.btn_ForgotPassword.TabIndex = 5;
            this.btn_ForgotPassword.Text = "Forgot Password?";
            this.btn_ForgotPassword.UseVisualStyleBackColor = true;
            this.btn_ForgotPassword.Click += new System.EventHandler(this.btn_ForgotPassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 161);
            this.Controls.Add(this.btn_ForgotPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_OverTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OverTitle;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_ForgotPassword;
    }
}

