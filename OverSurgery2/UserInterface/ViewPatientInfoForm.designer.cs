namespace OverSurgery2
{
    partial class ViewPatientInfoForm
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
            this.btn_EditPatient = new System.Windows.Forms.Button();
            this.lbl_Forename = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_ForenameText = new System.Windows.Forms.Label();
            this.lbl_SurnameText = new System.Windows.Forms.Label();
            this.lbl_DateOfBirthText = new System.Windows.Forms.Label();
            this.lbl_HouseNameNumberText = new System.Windows.Forms.Label();
            this.lbl_StreetNameText = new System.Windows.Forms.Label();
            this.lbl_PostCodeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EditPatient
            // 
            this.btn_EditPatient.Location = new System.Drawing.Point(15, 226);
            this.btn_EditPatient.Name = "btn_EditPatient";
            this.btn_EditPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPatient.TabIndex = 3;
            this.btn_EditPatient.Text = "Edit Patient";
            this.btn_EditPatient.UseVisualStyleBackColor = true;
            this.btn_EditPatient.Click += new System.EventHandler(this.btn_EditPatient_Click);
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(12, 9);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(57, 13);
            this.lbl_Forename.TabIndex = 4;
            this.lbl_Forename.Text = "Forename:";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(12, 22);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Surname.TabIndex = 5;
            this.lbl_Surname.Text = "Surname:";
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(12, 35);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lbl_DateOfBirth.TabIndex = 6;
            this.lbl_DateOfBirth.Text = "Date of Birth:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(12, 61);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(48, 13);
            this.lbl_Address.TabIndex = 7;
            this.lbl_Address.Text = "Address:";
            // 
            // lbl_ForenameText
            // 
            this.lbl_ForenameText.AutoSize = true;
            this.lbl_ForenameText.Location = new System.Drawing.Point(87, 9);
            this.lbl_ForenameText.Name = "lbl_ForenameText";
            this.lbl_ForenameText.Size = new System.Drawing.Size(80, 13);
            this.lbl_ForenameText.TabIndex = 8;
            this.lbl_ForenameText.Text = "Forename Here";
            // 
            // lbl_SurnameText
            // 
            this.lbl_SurnameText.AutoSize = true;
            this.lbl_SurnameText.Location = new System.Drawing.Point(87, 22);
            this.lbl_SurnameText.Name = "lbl_SurnameText";
            this.lbl_SurnameText.Size = new System.Drawing.Size(75, 13);
            this.lbl_SurnameText.TabIndex = 9;
            this.lbl_SurnameText.Text = "Surname Here";
            // 
            // lbl_DateOfBirthText
            // 
            this.lbl_DateOfBirthText.AutoSize = true;
            this.lbl_DateOfBirthText.Location = new System.Drawing.Point(87, 35);
            this.lbl_DateOfBirthText.Name = "lbl_DateOfBirthText";
            this.lbl_DateOfBirthText.Size = new System.Drawing.Size(94, 13);
            this.lbl_DateOfBirthText.TabIndex = 10;
            this.lbl_DateOfBirthText.Text = "Date Of Birth Here";
            // 
            // lbl_HouseNameNumberText
            // 
            this.lbl_HouseNameNumberText.AutoSize = true;
            this.lbl_HouseNameNumberText.Location = new System.Drawing.Point(87, 70);
            this.lbl_HouseNameNumberText.Name = "lbl_HouseNameNumberText";
            this.lbl_HouseNameNumberText.Size = new System.Drawing.Size(143, 13);
            this.lbl_HouseNameNumberText.TabIndex = 11;
            this.lbl_HouseNameNumberText.Text = "House Number / Name Here";
            // 
            // lbl_StreetNameText
            // 
            this.lbl_StreetNameText.AutoSize = true;
            this.lbl_StreetNameText.Location = new System.Drawing.Point(87, 83);
            this.lbl_StreetNameText.Name = "lbl_StreetNameText";
            this.lbl_StreetNameText.Size = new System.Drawing.Size(92, 13);
            this.lbl_StreetNameText.TabIndex = 12;
            this.lbl_StreetNameText.Text = "Street Name Here";
            // 
            // lbl_PostCodeText
            // 
            this.lbl_PostCodeText.AutoSize = true;
            this.lbl_PostCodeText.Location = new System.Drawing.Point(87, 96);
            this.lbl_PostCodeText.Name = "lbl_PostCodeText";
            this.lbl_PostCodeText.Size = new System.Drawing.Size(78, 13);
            this.lbl_PostCodeText.TabIndex = 13;
            this.lbl_PostCodeText.Text = "Postcode Here";
            // 
            // ViewPatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.lbl_PostCodeText);
            this.Controls.Add(this.lbl_StreetNameText);
            this.Controls.Add(this.lbl_HouseNameNumberText);
            this.Controls.Add(this.lbl_DateOfBirthText);
            this.Controls.Add(this.lbl_SurnameText);
            this.Controls.Add(this.lbl_ForenameText);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_DateOfBirth);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Forename);
            this.Controls.Add(this.btn_EditPatient);
            this.Name = "ViewPatientInfoForm";
            this.Text = "ViewPatientInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewPatientInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewPatientInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_EditPatient;
        private System.Windows.Forms.Label lbl_Forename;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_ForenameText;
        private System.Windows.Forms.Label lbl_SurnameText;
        private System.Windows.Forms.Label lbl_DateOfBirthText;
        private System.Windows.Forms.Label lbl_HouseNameNumberText;
        private System.Windows.Forms.Label lbl_StreetNameText;
        private System.Windows.Forms.Label lbl_PostCodeText;
    }
}