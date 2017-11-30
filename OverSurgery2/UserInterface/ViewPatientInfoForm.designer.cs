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
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_PhoneNumberText = new System.Windows.Forms.Label();
            this.lbl_DoctorNameText = new System.Windows.Forms.Label();
            this.lbl_DoctorName = new System.Windows.Forms.Label();
            this.lst_PatientsPres = new System.Windows.Forms.ListView();
            this.btn_Extend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EditPatient
            // 
            this.btn_EditPatient.Location = new System.Drawing.Point(13, 481);
            this.btn_EditPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_EditPatient.Name = "btn_EditPatient";
            this.btn_EditPatient.Size = new System.Drawing.Size(112, 35);
            this.btn_EditPatient.TabIndex = 3;
            this.btn_EditPatient.Text = "Edit Patient";
            this.btn_EditPatient.UseVisualStyleBackColor = true;
            this.btn_EditPatient.Click += new System.EventHandler(this.btn_EditPatient_Click);
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(18, 14);
            this.lbl_Forename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(86, 20);
            this.lbl_Forename.TabIndex = 4;
            this.lbl_Forename.Text = "Forename:";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(18, 34);
            this.lbl_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(78, 20);
            this.lbl_Surname.TabIndex = 5;
            this.lbl_Surname.Text = "Surname:";
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(18, 54);
            this.lbl_DateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(103, 20);
            this.lbl_DateOfBirth.TabIndex = 6;
            this.lbl_DateOfBirth.Text = "Date of Birth:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(18, 134);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(72, 20);
            this.lbl_Address.TabIndex = 7;
            this.lbl_Address.Text = "Address:";
            // 
            // lbl_ForenameText
            // 
            this.lbl_ForenameText.AutoSize = true;
            this.lbl_ForenameText.Location = new System.Drawing.Point(147, 14);
            this.lbl_ForenameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ForenameText.Name = "lbl_ForenameText";
            this.lbl_ForenameText.Size = new System.Drawing.Size(121, 20);
            this.lbl_ForenameText.TabIndex = 8;
            this.lbl_ForenameText.Text = "Forename Here";
            // 
            // lbl_SurnameText
            // 
            this.lbl_SurnameText.AutoSize = true;
            this.lbl_SurnameText.Location = new System.Drawing.Point(146, 34);
            this.lbl_SurnameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SurnameText.Name = "lbl_SurnameText";
            this.lbl_SurnameText.Size = new System.Drawing.Size(113, 20);
            this.lbl_SurnameText.TabIndex = 9;
            this.lbl_SurnameText.Text = "Surname Here";
            // 
            // lbl_DateOfBirthText
            // 
            this.lbl_DateOfBirthText.AutoSize = true;
            this.lbl_DateOfBirthText.Location = new System.Drawing.Point(147, 54);
            this.lbl_DateOfBirthText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateOfBirthText.Name = "lbl_DateOfBirthText";
            this.lbl_DateOfBirthText.Size = new System.Drawing.Size(141, 20);
            this.lbl_DateOfBirthText.TabIndex = 10;
            this.lbl_DateOfBirthText.Text = "Date Of Birth Here";
            // 
            // lbl_HouseNameNumberText
            // 
            this.lbl_HouseNameNumberText.AutoSize = true;
            this.lbl_HouseNameNumberText.Location = new System.Drawing.Point(130, 148);
            this.lbl_HouseNameNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HouseNameNumberText.Name = "lbl_HouseNameNumberText";
            this.lbl_HouseNameNumberText.Size = new System.Drawing.Size(209, 20);
            this.lbl_HouseNameNumberText.TabIndex = 11;
            this.lbl_HouseNameNumberText.Text = "House Number / Name Here";
            // 
            // lbl_StreetNameText
            // 
            this.lbl_StreetNameText.AutoSize = true;
            this.lbl_StreetNameText.Location = new System.Drawing.Point(130, 168);
            this.lbl_StreetNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StreetNameText.Name = "lbl_StreetNameText";
            this.lbl_StreetNameText.Size = new System.Drawing.Size(138, 20);
            this.lbl_StreetNameText.TabIndex = 12;
            this.lbl_StreetNameText.Text = "Street Name Here";
            // 
            // lbl_PostCodeText
            // 
            this.lbl_PostCodeText.AutoSize = true;
            this.lbl_PostCodeText.Location = new System.Drawing.Point(130, 188);
            this.lbl_PostCodeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PostCodeText.Name = "lbl_PostCodeText";
            this.lbl_PostCodeText.Size = new System.Drawing.Size(115, 20);
            this.lbl_PostCodeText.TabIndex = 13;
            this.lbl_PostCodeText.Text = "Postcode Here";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(18, 74);
            this.lbl_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lbl_PhoneNumber.TabIndex = 14;
            this.lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // lbl_PhoneNumberText
            // 
            this.lbl_PhoneNumberText.AutoSize = true;
            this.lbl_PhoneNumberText.Location = new System.Drawing.Point(147, 74);
            this.lbl_PhoneNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhoneNumberText.Name = "lbl_PhoneNumberText";
            this.lbl_PhoneNumberText.Size = new System.Drawing.Size(154, 20);
            this.lbl_PhoneNumberText.TabIndex = 15;
            this.lbl_PhoneNumberText.Text = "Phone Number Here";
            // 
            // lbl_DoctorNameText
            // 
            this.lbl_DoctorNameText.AutoSize = true;
            this.lbl_DoctorNameText.Location = new System.Drawing.Point(147, 94);
            this.lbl_DoctorNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DoctorNameText.Name = "lbl_DoctorNameText";
            this.lbl_DoctorNameText.Size = new System.Drawing.Size(142, 20);
            this.lbl_DoctorNameText.TabIndex = 17;
            this.lbl_DoctorNameText.Text = "Doctor Name Here";
            // 
            // lbl_DoctorName
            // 
            this.lbl_DoctorName.AutoSize = true;
            this.lbl_DoctorName.Location = new System.Drawing.Point(18, 94);
            this.lbl_DoctorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DoctorName.Name = "lbl_DoctorName";
            this.lbl_DoctorName.Size = new System.Drawing.Size(61, 20);
            this.lbl_DoctorName.TabIndex = 16;
            this.lbl_DoctorName.Text = "Doctor:";
            // 
            // lst_PatientsPres
            // 
            this.lst_PatientsPres.Cursor = System.Windows.Forms.Cursors.Default;
            this.lst_PatientsPres.FullRowSelect = true;
            this.lst_PatientsPres.Location = new System.Drawing.Point(12, 227);
            this.lst_PatientsPres.Name = "lst_PatientsPres";
            this.lst_PatientsPres.Size = new System.Drawing.Size(517, 246);
            this.lst_PatientsPres.TabIndex = 18;
            this.lst_PatientsPres.UseCompatibleStateImageBehavior = false;
            this.lst_PatientsPres.View = System.Windows.Forms.View.Details;
            this.lst_PatientsPres.SelectedIndexChanged += new System.EventHandler(this.lst_PatientsPres_SelectedIndexChanged);
            // 
            // btn_Extend
            // 
            this.btn_Extend.Location = new System.Drawing.Point(368, 479);
            this.btn_Extend.Name = "btn_Extend";
            this.btn_Extend.Size = new System.Drawing.Size(161, 37);
            this.btn_Extend.TabIndex = 19;
            this.btn_Extend.Text = "Extend Prescription";
            this.btn_Extend.UseVisualStyleBackColor = true;
            this.btn_Extend.Click += new System.EventHandler(this.btn_Extend_Click);
            // 
            // ViewPatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 530);
            this.Controls.Add(this.btn_Extend);
            this.Controls.Add(this.lst_PatientsPres);
            this.Controls.Add(this.lbl_DoctorNameText);
            this.Controls.Add(this.lbl_DoctorName);
            this.Controls.Add(this.lbl_PhoneNumberText);
            this.Controls.Add(this.lbl_PhoneNumber);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_PhoneNumberText;
        private System.Windows.Forms.Label lbl_DoctorNameText;
        private System.Windows.Forms.Label lbl_DoctorName;
        private System.Windows.Forms.ListView lst_PatientsPres;
        private System.Windows.Forms.Button btn_Extend;
    }
}