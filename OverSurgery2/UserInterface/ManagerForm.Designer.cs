namespace OverSurgery2
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
            this.lblPracticeNumber = new System.Windows.Forms.Label();
            this.txtPracticeNumberAdd = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblHouseName = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblAddressLine = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtUpdateHouseName = new System.Windows.Forms.TextBox();
            this.txtUpdateHouseNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateAddressLine = new System.Windows.Forms.TextBox();
            this.txtUpdatePostCode = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddStaff = new System.Windows.Forms.TabPage();
            this.cboAddGender = new System.Windows.Forms.ComboBox();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPostCode = new System.Windows.Forms.TextBox();
            this.txtAddAddressLine = new System.Windows.Forms.TextBox();
            this.txtAddHouseNumber = new System.Windows.Forms.TextBox();
            this.txtAddHouseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabUpdateStaff = new System.Windows.Forms.TabPage();
            this.lbl_UpdateType = new System.Windows.Forms.Label();
            this.cboUpdateType = new System.Windows.Forms.ComboBox();
            this.cboUpdateGender = new System.Windows.Forms.ComboBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateForename = new System.Windows.Forms.TextBox();
            this.btnAddMedication = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAddStaff.SuspendLayout();
            this.tabUpdateStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(590, 351);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(91, 23);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Location = new System.Drawing.Point(493, 351);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveStaff.TabIndex = 1;
            this.btnRemoveStaff.Text = "Remove Staff";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            this.btnRemoveStaff.MouseHover += new System.EventHandler(this.btnRemoveStaff_MouseHover);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(590, 351);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateStaff.TabIndex = 2;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnUpdateRota
            // 
            this.btnUpdateRota.Location = new System.Drawing.Point(522, 460);
            this.btnUpdateRota.Name = "btnUpdateRota";
            this.btnUpdateRota.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateRota.TabIndex = 3;
            this.btnUpdateRota.Text = "Update Rota";
            this.btnUpdateRota.UseVisualStyleBackColor = true;
            this.btnUpdateRota.Click += new System.EventHandler(this.btnUpdateRota_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(619, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPracticeNumber
            // 
            this.lblPracticeNumber.AutoSize = true;
            this.lblPracticeNumber.Location = new System.Drawing.Point(77, 293);
            this.lblPracticeNumber.Name = "lblPracticeNumber";
            this.lblPracticeNumber.Size = new System.Drawing.Size(83, 13);
            this.lblPracticeNumber.TabIndex = 12;
            this.lblPracticeNumber.Text = "PracticeNumber";
            // 
            // txtPracticeNumberAdd
            // 
            this.txtPracticeNumberAdd.Location = new System.Drawing.Point(166, 290);
            this.txtPracticeNumberAdd.Name = "txtPracticeNumberAdd";
            this.txtPracticeNumberAdd.Size = new System.Drawing.Size(100, 20);
            this.txtPracticeNumberAdd.TabIndex = 13;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(117, 239);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(127, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(166, 264);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEmail.TabIndex = 19;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User Name";
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(78, 14);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchUserName.TabIndex = 21;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Location = new System.Drawing.Point(185, 12);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(91, 23);
            this.btnSearchUserName.TabIndex = 22;
            this.btnSearchUserName.Text = "Search Staff";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Location = new System.Drawing.Point(103, 44);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(56, 13);
            this.lblStaffType.TabIndex = 24;
            this.lblStaffType.Text = "Staff Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(166, 41);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 21);
            this.cboType.TabIndex = 25;
            this.cboType.SelectedValueChanged += new System.EventHandler(this.cboType_SelectedValueChanged);
            // 
            // lblHouseName
            // 
            this.lblHouseName.AutoSize = true;
            this.lblHouseName.Location = new System.Drawing.Point(382, 44);
            this.lblHouseName.Name = "lblHouseName";
            this.lblHouseName.Size = new System.Drawing.Size(69, 13);
            this.lblHouseName.TabIndex = 34;
            this.lblHouseName.Text = "House Name";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(373, 71);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(78, 13);
            this.lblHouseNumber.TabIndex = 35;
            this.lblHouseNumber.Text = "House Number";
            // 
            // lblAddressLine
            // 
            this.lblAddressLine.AutoSize = true;
            this.lblAddressLine.Location = new System.Drawing.Point(374, 96);
            this.lblAddressLine.Name = "lblAddressLine";
            this.lblAddressLine.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine.TabIndex = 36;
            this.lblAddressLine.Text = "Address Line 1";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(395, 122);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(56, 13);
            this.lblPostCode.TabIndex = 37;
            this.lblPostCode.Text = "Post Code";
            // 
            // txtUpdateHouseName
            // 
            this.txtUpdateHouseName.Location = new System.Drawing.Point(457, 41);
            this.txtUpdateHouseName.Name = "txtUpdateHouseName";
            this.txtUpdateHouseName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateHouseName.TabIndex = 38;
            // 
            // txtUpdateHouseNumber
            // 
            this.txtUpdateHouseNumber.Location = new System.Drawing.Point(457, 67);
            this.txtUpdateHouseNumber.Name = "txtUpdateHouseNumber";
            this.txtUpdateHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateHouseNumber.TabIndex = 39;
            // 
            // txtUpdateAddressLine
            // 
            this.txtUpdateAddressLine.Location = new System.Drawing.Point(457, 93);
            this.txtUpdateAddressLine.Name = "txtUpdateAddressLine";
            this.txtUpdateAddressLine.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAddressLine.TabIndex = 40;
            // 
            // txtUpdatePostCode
            // 
            this.txtUpdatePostCode.Location = new System.Drawing.Point(457, 119);
            this.txtUpdatePostCode.Name = "txtUpdatePostCode";
            this.txtUpdatePostCode.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePostCode.TabIndex = 41;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddStaff);
            this.tabControl1.Controls.Add(this.tabUpdateStaff);
            this.tabControl1.Location = new System.Drawing.Point(15, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 406);
            this.tabControl1.TabIndex = 2;
            // 
            // tabAddStaff
            // 
            this.tabAddStaff.Controls.Add(this.cboAddGender);
            this.tabAddStaff.Controls.Add(this.txtAddPhone);
            this.tabAddStaff.Controls.Add(this.label10);
            this.tabAddStaff.Controls.Add(this.txtAddPassword);
            this.tabAddStaff.Controls.Add(this.label11);
            this.tabAddStaff.Controls.Add(this.txtAddUserName);
            this.tabAddStaff.Controls.Add(this.label12);
            this.tabAddStaff.Controls.Add(this.cboType);
            this.tabAddStaff.Controls.Add(this.btnAddStaff);
            this.tabAddStaff.Controls.Add(this.txtAddSurname);
            this.tabAddStaff.Controls.Add(this.lblStaffType);
            this.tabAddStaff.Controls.Add(this.label13);
            this.tabAddStaff.Controls.Add(this.label14);
            this.tabAddStaff.Controls.Add(this.txtAddForename);
            this.tabAddStaff.Controls.Add(this.label15);
            this.tabAddStaff.Controls.Add(this.txtPracticeNumberAdd);
            this.tabAddStaff.Controls.Add(this.lblPracticeNumber);
            this.tabAddStaff.Controls.Add(this.label16);
            this.tabAddStaff.Controls.Add(this.txtAddEmail);
            this.tabAddStaff.Controls.Add(this.txtAddPostCode);
            this.tabAddStaff.Controls.Add(this.txtAddAddressLine);
            this.tabAddStaff.Controls.Add(this.txtAddHouseNumber);
            this.tabAddStaff.Controls.Add(this.txtAddHouseName);
            this.tabAddStaff.Controls.Add(this.label6);
            this.tabAddStaff.Controls.Add(this.label7);
            this.tabAddStaff.Controls.Add(this.label8);
            this.tabAddStaff.Controls.Add(this.label9);
            this.tabAddStaff.Location = new System.Drawing.Point(4, 22);
            this.tabAddStaff.Name = "tabAddStaff";
            this.tabAddStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddStaff.Size = new System.Drawing.Size(687, 380);
            this.tabAddStaff.TabIndex = 1;
            this.tabAddStaff.Text = "Add Staff";
            this.tabAddStaff.UseVisualStyleBackColor = true;
            // 
            // cboAddGender
            // 
            this.cboAddGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddGender.FormattingEnabled = true;
            this.cboAddGender.Location = new System.Drawing.Point(166, 237);
            this.cboAddGender.Name = "cboAddGender";
            this.cboAddGender.Size = new System.Drawing.Size(100, 21);
            this.cboAddGender.TabIndex = 64;
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(166, 210);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(100, 20);
            this.txtAddPhone.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Phone Number";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(166, 94);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAddPassword.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Password";
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(166, 68);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(100, 20);
            this.txtAddUserName.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "User Name";
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(166, 184);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(100, 20);
            this.txtAddSurname.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Surname";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Forename";
            // 
            // txtAddForename
            // 
            this.txtAddForename.Location = new System.Drawing.Point(166, 158);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(100, 20);
            this.txtAddForename.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(117, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Gender";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(127, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(166, 264);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAddEmail.TabIndex = 57;
            // 
            // txtAddPostCode
            // 
            this.txtAddPostCode.Location = new System.Drawing.Point(457, 119);
            this.txtAddPostCode.Name = "txtAddPostCode";
            this.txtAddPostCode.Size = new System.Drawing.Size(100, 20);
            this.txtAddPostCode.TabIndex = 49;
            // 
            // txtAddAddressLine
            // 
            this.txtAddAddressLine.Location = new System.Drawing.Point(457, 93);
            this.txtAddAddressLine.Name = "txtAddAddressLine";
            this.txtAddAddressLine.Size = new System.Drawing.Size(100, 20);
            this.txtAddAddressLine.TabIndex = 48;
            // 
            // txtAddHouseNumber
            // 
            this.txtAddHouseNumber.Location = new System.Drawing.Point(457, 67);
            this.txtAddHouseNumber.Name = "txtAddHouseNumber";
            this.txtAddHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAddHouseNumber.TabIndex = 47;
            // 
            // txtAddHouseName
            // 
            this.txtAddHouseName.Location = new System.Drawing.Point(457, 41);
            this.txtAddHouseName.Name = "txtAddHouseName";
            this.txtAddHouseName.Size = new System.Drawing.Size(100, 20);
            this.txtAddHouseName.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Post Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Address Line 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "House Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "House Name";
            // 
            // tabUpdateStaff
            // 
            this.tabUpdateStaff.Controls.Add(this.lbl_UpdateType);
            this.tabUpdateStaff.Controls.Add(this.cboUpdateType);
            this.tabUpdateStaff.Controls.Add(this.cboUpdateGender);
            this.tabUpdateStaff.Controls.Add(this.txtUpdatePhone);
            this.tabUpdateStaff.Controls.Add(this.txtUpdatePostCode);
            this.tabUpdateStaff.Controls.Add(this.label5);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateAddressLine);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateHouseNumber);
            this.tabUpdateStaff.Controls.Add(this.btnRemoveStaff);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateHouseName);
            this.tabUpdateStaff.Controls.Add(this.lblPostCode);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateUserName);
            this.tabUpdateStaff.Controls.Add(this.lblAddressLine);
            this.tabUpdateStaff.Controls.Add(this.label3);
            this.tabUpdateStaff.Controls.Add(this.lblHouseNumber);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateSurname);
            this.tabUpdateStaff.Controls.Add(this.lblHouseName);
            this.tabUpdateStaff.Controls.Add(this.label1);
            this.tabUpdateStaff.Controls.Add(this.label2);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateForename);
            this.tabUpdateStaff.Controls.Add(this.btnUpdateStaff);
            this.tabUpdateStaff.Controls.Add(this.lblGender);
            this.tabUpdateStaff.Controls.Add(this.lblEmail);
            this.tabUpdateStaff.Controls.Add(this.txtUpdateEmail);
            this.tabUpdateStaff.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateStaff.Name = "tabUpdateStaff";
            this.tabUpdateStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateStaff.Size = new System.Drawing.Size(687, 380);
            this.tabUpdateStaff.TabIndex = 0;
            this.tabUpdateStaff.Text = "Update Staff";
            this.tabUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // lbl_UpdateType
            // 
            this.lbl_UpdateType.AutoSize = true;
            this.lbl_UpdateType.Location = new System.Drawing.Point(103, 44);
            this.lbl_UpdateType.Name = "lbl_UpdateType";
            this.lbl_UpdateType.Size = new System.Drawing.Size(56, 13);
            this.lbl_UpdateType.TabIndex = 44;
            this.lbl_UpdateType.Text = "Staff Type";
            // 
            // cboUpdateType
            // 
            this.cboUpdateType.FormattingEnabled = true;
            this.cboUpdateType.Location = new System.Drawing.Point(166, 41);
            this.cboUpdateType.Name = "cboUpdateType";
            this.cboUpdateType.Size = new System.Drawing.Size(100, 21);
            this.cboUpdateType.TabIndex = 43;
            // 
            // cboUpdateGender
            // 
            this.cboUpdateGender.FormattingEnabled = true;
            this.cboUpdateGender.Location = new System.Drawing.Point(166, 237);
            this.cboUpdateGender.Name = "cboUpdateGender";
            this.cboUpdateGender.Size = new System.Drawing.Size(100, 21);
            this.cboUpdateGender.TabIndex = 42;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(166, 210);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePhone.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Phone Number";
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Location = new System.Drawing.Point(166, 68);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateUserName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "User Name";
            // 
            // txtUpdateSurname
            // 
            this.txtUpdateSurname.Location = new System.Drawing.Point(166, 184);
            this.txtUpdateSurname.Name = "txtUpdateSurname";
            this.txtUpdateSurname.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateSurname.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Forename";
            // 
            // txtUpdateForename
            // 
            this.txtUpdateForename.Location = new System.Drawing.Point(166, 158);
            this.txtUpdateForename.Name = "txtUpdateForename";
            this.txtUpdateForename.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateForename.TabIndex = 9;
            // 
            // btnAddMedication
            // 
            this.btnAddMedication.Location = new System.Drawing.Point(425, 460);
            this.btnAddMedication.Name = "btnAddMedication";
            this.btnAddMedication.Size = new System.Drawing.Size(91, 23);
            this.btnAddMedication.TabIndex = 0;
            this.btnAddMedication.Text = "Medication";
            this.btnAddMedication.UseVisualStyleBackColor = true;
            this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 495);
            this.Controls.Add(this.btnAddMedication);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSearchUserName);
            this.Controls.Add(this.txtSearchUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRota);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAddStaff.ResumeLayout(false);
            this.tabAddStaff.PerformLayout();
            this.tabUpdateStaff.ResumeLayout(false);
            this.tabUpdateStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnUpdateRota;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPracticeNumber;
        private System.Windows.Forms.TextBox txtPracticeNumberAdd;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblHouseName;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblAddressLine;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtUpdateHouseName;
        private System.Windows.Forms.TextBox txtUpdateHouseNumber;
        private System.Windows.Forms.TextBox txtUpdateAddressLine;
        private System.Windows.Forms.TextBox txtUpdatePostCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddStaff;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPostCode;
        private System.Windows.Forms.TextBox txtAddAddressLine;
        private System.Windows.Forms.TextBox txtAddHouseNumber;
        private System.Windows.Forms.TextBox txtAddHouseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabUpdateStaff;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateForename;
        private System.Windows.Forms.Button btnAddMedication;
        private System.Windows.Forms.ComboBox cboUpdateGender;
        private System.Windows.Forms.ComboBox cboAddGender;
        private System.Windows.Forms.Label lbl_UpdateType;
        private System.Windows.Forms.ComboBox cboUpdateType;
    }
}