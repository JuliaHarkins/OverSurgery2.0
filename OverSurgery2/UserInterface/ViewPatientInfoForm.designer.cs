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
            this.lbl_Forename = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_EditPatient = new System.Windows.Forms.Button();
            this.lbl_PatientForeName = new System.Windows.Forms.Label();
            this.lbl_PatientSurName = new System.Windows.Forms.Label();
            this.lbl_PatientAddress = new System.Windows.Forms.Label();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.lbl_PatientDateOfBirth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(78, 34);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(57, 13);
            this.lbl_Forename.TabIndex = 0;
            this.lbl_Forename.Text = "Forename:";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(83, 47);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Surname.TabIndex = 1;
            this.lbl_Surname.Text = "Surname:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(87, 73);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(48, 13);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address:";
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
            // lbl_PatientForeName
            // 
            this.lbl_PatientForeName.AutoSize = true;
            this.lbl_PatientForeName.Location = new System.Drawing.Point(141, 34);
            this.lbl_PatientForeName.Name = "lbl_PatientForeName";
            this.lbl_PatientForeName.Size = new System.Drawing.Size(0, 13);
            this.lbl_PatientForeName.TabIndex = 4;
            // 
            // lbl_PatientSurName
            // 
            this.lbl_PatientSurName.AutoSize = true;
            this.lbl_PatientSurName.Location = new System.Drawing.Point(141, 47);
            this.lbl_PatientSurName.Name = "lbl_PatientSurName";
            this.lbl_PatientSurName.Size = new System.Drawing.Size(0, 13);
            this.lbl_PatientSurName.TabIndex = 5;
            // 
            // lbl_PatientAddress
            // 
            this.lbl_PatientAddress.AutoSize = true;
            this.lbl_PatientAddress.Location = new System.Drawing.Point(141, 73);
            this.lbl_PatientAddress.Name = "lbl_PatientAddress";
            this.lbl_PatientAddress.Size = new System.Drawing.Size(0, 13);
            this.lbl_PatientAddress.TabIndex = 6;
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(66, 60);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lbl_DateOfBirth.TabIndex = 7;
            this.lbl_DateOfBirth.Text = "Date of Birth:";
            // 
            // lbl_PatientDateOfBirth
            // 
            this.lbl_PatientDateOfBirth.AutoSize = true;
            this.lbl_PatientDateOfBirth.Location = new System.Drawing.Point(141, 60);
            this.lbl_PatientDateOfBirth.Name = "lbl_PatientDateOfBirth";
            this.lbl_PatientDateOfBirth.Size = new System.Drawing.Size(0, 13);
            this.lbl_PatientDateOfBirth.TabIndex = 8;
            // 
            // ViewPatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.lbl_PatientDateOfBirth);
            this.Controls.Add(this.lbl_DateOfBirth);
            this.Controls.Add(this.lbl_PatientAddress);
            this.Controls.Add(this.lbl_PatientSurName);
            this.Controls.Add(this.lbl_PatientForeName);
            this.Controls.Add(this.btn_EditPatient);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Forename);
            this.Name = "ViewPatientInfoForm";
            this.Text = "ViewPatientInfoForm";
            this.Load += new System.EventHandler(this.ViewPatientInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Forename;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_EditPatient;
        private System.Windows.Forms.Label lbl_PatientForeName;
        private System.Windows.Forms.Label lbl_PatientSurName;
        private System.Windows.Forms.Label lbl_PatientAddress;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lbl_PatientDateOfBirth;
    }
}