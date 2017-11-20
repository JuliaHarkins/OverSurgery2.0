﻿namespace OverSurgery2
{
    partial class ManagerForm
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnUpdateRota = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPracticeNumber = new System.Windows.Forms.Label();
            this.txtPracticeNumber = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.lblDatabaseHelper1 = new System.Windows.Forms.Label();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblTypeHelper = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDatabaseHelper2 = new System.Windows.Forms.Label();
            this.lblHouseName = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblAddressLine = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtHouseName = new System.Windows.Forms.TextBox();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtAddressLine = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(12, 400);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(91, 23);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Location = new System.Drawing.Point(206, 400);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveStaff.TabIndex = 1;
            this.btnRemoveStaff.Text = "Remove Staff";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(109, 400);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateStaff.TabIndex = 2;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnUpdateRota
            // 
            this.btnUpdateRota.Location = new System.Drawing.Point(616, 400);
            this.btnUpdateRota.Name = "btnUpdateRota";
            this.btnUpdateRota.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateRota.TabIndex = 3;
            this.btnUpdateRota.Text = "Update Rota";
            this.btnUpdateRota.UseVisualStyleBackColor = true;
            this.btnUpdateRota.Click += new System.EventHandler(this.btnUpdateRota_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(93, 123);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 5;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(33, 126);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 6;
            this.lblForename.Text = "Forename";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(33, 152);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(88, 149);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // lblPracticeNumber
            // 
            this.lblPracticeNumber.AutoSize = true;
            this.lblPracticeNumber.Location = new System.Drawing.Point(33, 178);
            this.lblPracticeNumber.Name = "lblPracticeNumber";
            this.lblPracticeNumber.Size = new System.Drawing.Size(83, 13);
            this.lblPracticeNumber.TabIndex = 12;
            this.lblPracticeNumber.Text = "PracticeNumber";
            // 
            // txtPracticeNumber
            // 
            this.txtPracticeNumber.Location = new System.Drawing.Point(122, 175);
            this.txtPracticeNumber.Name = "txtPracticeNumber";
            this.txtPracticeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPracticeNumber.TabIndex = 13;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(33, 100);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(43, 13);
            this.lblStaffID.TabIndex = 14;
            this.lblStaffID.Text = "Staff ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(82, 97);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 15;
            this.txtStaffID.Text = "Auto Increments";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(33, 204);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(81, 201);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(33, 74);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(99, 71);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 21;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Location = new System.Drawing.Point(206, 69);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(91, 23);
            this.btnSearchUserName.TabIndex = 22;
            this.btnSearchUserName.Text = "Search User";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // lblDatabaseHelper1
            // 
            this.lblDatabaseHelper1.AutoSize = true;
            this.lblDatabaseHelper1.Location = new System.Drawing.Point(188, 100);
            this.lblDatabaseHelper1.Name = "lblDatabaseHelper1";
            this.lblDatabaseHelper1.Size = new System.Drawing.Size(169, 13);
            this.lblDatabaseHelper1.TabIndex = 23;
            this.lblDatabaseHelper1.Text = "Database handles this field for you";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Location = new System.Drawing.Point(33, 257);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(56, 13);
            this.lblStaffType.TabIndex = 24;
            this.lblStaffType.Text = "Staff Type";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboType.Location = new System.Drawing.Point(96, 254);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 25;
            // 
            // lblTypeHelper
            // 
            this.lblTypeHelper.AutoSize = true;
            this.lblTypeHelper.Location = new System.Drawing.Point(223, 257);
            this.lblTypeHelper.Name = "lblTypeHelper";
            this.lblTypeHelper.Size = new System.Drawing.Size(0, 13);
            this.lblTypeHelper.TabIndex = 26;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(33, 285);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 281);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 28;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(33, 310);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(429, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 13);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address ID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 307);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(493, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.Text = "Auto Increments";
            // 
            // lblDatabaseHelper2
            // 
            this.lblDatabaseHelper2.AutoSize = true;
            this.lblDatabaseHelper2.Location = new System.Drawing.Point(599, 74);
            this.lblDatabaseHelper2.Name = "lblDatabaseHelper2";
            this.lblDatabaseHelper2.Size = new System.Drawing.Size(169, 13);
            this.lblDatabaseHelper2.TabIndex = 33;
            this.lblDatabaseHelper2.Text = "Database handles this field for you";
            // 
            // lblHouseName
            // 
            this.lblHouseName.AutoSize = true;
            this.lblHouseName.Location = new System.Drawing.Point(429, 100);
            this.lblHouseName.Name = "lblHouseName";
            this.lblHouseName.Size = new System.Drawing.Size(69, 13);
            this.lblHouseName.TabIndex = 34;
            this.lblHouseName.Text = "House Name";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(429, 126);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(78, 13);
            this.lblHouseNumber.TabIndex = 35;
            this.lblHouseNumber.Text = "House Number";
            // 
            // lblAddressLine
            // 
            this.lblAddressLine.AutoSize = true;
            this.lblAddressLine.Location = new System.Drawing.Point(429, 152);
            this.lblAddressLine.Name = "lblAddressLine";
            this.lblAddressLine.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine.TabIndex = 36;
            this.lblAddressLine.Text = "Address Line 1";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(429, 178);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(56, 13);
            this.lblPostCode.TabIndex = 37;
            this.lblPostCode.Text = "Post Code";
            // 
            // txtHouseName
            // 
            this.txtHouseName.Location = new System.Drawing.Point(504, 97);
            this.txtHouseName.Name = "txtHouseName";
            this.txtHouseName.Size = new System.Drawing.Size(100, 20);
            this.txtHouseName.TabIndex = 38;
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(512, 123);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtHouseNumber.TabIndex = 39;
            // 
            // txtAddressLine
            // 
            this.txtAddressLine.Location = new System.Drawing.Point(512, 149);
            this.txtAddressLine.Name = "txtAddressLine";
            this.txtAddressLine.Size = new System.Drawing.Size(100, 20);
            this.txtAddressLine.TabIndex = 40;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(491, 175);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostCode.TabIndex = 41;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 435);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtAddressLine);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.txtHouseName);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblAddressLine);
            this.Controls.Add(this.lblHouseNumber);
            this.Controls.Add(this.lblHouseName);
            this.Controls.Add(this.lblDatabaseHelper2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTypeHelper);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblStaffType);
            this.Controls.Add(this.lblDatabaseHelper1);
            this.Controls.Add(this.btnSearchUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.txtPracticeNumber);
            this.Controls.Add(this.lblPracticeNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRota);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnRemoveStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnUpdateRota;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblPracticeNumber;
        private System.Windows.Forms.TextBox txtPracticeNumber;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.Label lblDatabaseHelper1;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblTypeHelper;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDatabaseHelper2;
        private System.Windows.Forms.Label lblHouseName;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblAddressLine;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtHouseName;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.TextBox txtAddressLine;
        private System.Windows.Forms.TextBox txtPostCode;
    }
}