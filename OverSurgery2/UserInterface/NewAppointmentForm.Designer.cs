namespace OverSurgery2.UserInterface
{
    partial class NewAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtPatIDSet = new System.Windows.Forms.Label();
            this.dGAppointment = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDoctorFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.txtMedStaffName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(135, 32);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(171, 30);
            this.txtForename.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(135, 68);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(171, 30);
            this.txtSurname.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(332, 67);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(125, 31);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtPatIDSet
            // 
            this.txtPatIDSet.AutoSize = true;
            this.txtPatIDSet.Location = new System.Drawing.Point(27, 113);
            this.txtPatIDSet.Name = "txtPatIDSet";
            this.txtPatIDSet.Size = new System.Drawing.Size(201, 25);
            this.txtPatIDSet.TabIndex = 5;
            this.txtPatIDSet.Text = "[Patient ID NOT SET]";
            // 
            // dGAppointment
            // 
            this.dGAppointment.AllowUserToAddRows = false;
            this.dGAppointment.AllowUserToDeleteRows = false;
            this.dGAppointment.AllowUserToResizeColumns = false;
            this.dGAppointment.AllowUserToResizeRows = false;
            this.dGAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.AppointmentDate,
            this.AppointmentTime,
            this.Doctor});
            this.dGAppointment.Location = new System.Drawing.Point(12, 249);
            this.dGAppointment.Name = "dGAppointment";
            this.dGAppointment.ReadOnly = true;
            this.dGAppointment.RowTemplate.Height = 24;
            this.dGAppointment.Size = new System.Drawing.Size(823, 369);
            this.dGAppointment.TabIndex = 6;
            // 
            // AppointmentID
            // 
            this.AppointmentID.HeaderText = "Appointment ID";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            this.AppointmentID.Visible = false;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            this.AppointmentDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentDate.Width = 180;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AppointmentTime.HeaderText = "Appointment Time";
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.ReadOnly = true;
            this.AppointmentTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentTime.Width = 182;
            // 
            // Doctor
            // 
            this.Doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            this.Doctor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Doctor.Width = 98;
            // 
            // cbxDoctorFilter
            // 
            this.cbxDoctorFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoctorFilter.FormattingEnabled = true;
            this.cbxDoctorFilter.Location = new System.Drawing.Point(592, 214);
            this.cbxDoctorFilter.Name = "cbxDoctorFilter";
            this.cbxDoctorFilter.Size = new System.Drawing.Size(243, 33);
            this.cbxDoctorFilter.TabIndex = 7;
            this.cbxDoctorFilter.SelectedIndexChanged += new System.EventHandler(this.cbxDoctorFilter_SelectedIndexChanged);
            this.cbxDoctorFilter.DropDownClosed += new System.EventHandler(this.cbxDoctorFilter_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(727, 633);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(108, 32);
            this.BtnReturn.TabIndex = 11;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(11, 633);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(108, 32);
            this.BtnConfirm.TabIndex = 12;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(61, 214);
            this.cbxDay.MaximumSize = new System.Drawing.Size(100, 0);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(58, 33);
            this.cbxDay.TabIndex = 13;
            this.cbxDay.SelectedIndexChanged += new System.EventHandler(this.cbxDay_DropDownClosed);
            this.cbxDay.DropDownClosed += new System.EventHandler(this.cbxDay_DropDownClosed);
            // 
            // cbxMonth
            // 
            this.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Location = new System.Drawing.Point(125, 214);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(89, 33);
            this.cbxMonth.TabIndex = 14;
            this.cbxMonth.SelectedIndexChanged += new System.EventHandler(this.cbxMonth_SelectedIndexChanged);
            this.cbxMonth.DropDownClosed += new System.EventHandler(this.cbxMonth_DropDownClosed);
            // 
            // cbxYear
            // 
            this.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(220, 214);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(86, 33);
            this.cbxYear.TabIndex = 15;
            this.cbxYear.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            this.cbxYear.DropDownClosed += new System.EventHandler(this.cbxYear_DropDownClosed);
            // 
            // txtMedStaffName
            // 
            this.txtMedStaffName.AutoSize = true;
            this.txtMedStaffName.Location = new System.Drawing.Point(526, 633);
            this.txtMedStaffName.Name = "txtMedStaffName";
            this.txtMedStaffName.Size = new System.Drawing.Size(0, 25);
            this.txtMedStaffName.TabIndex = 16;
            this.txtMedStaffName.Visible = false;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 675);
            this.Controls.Add(this.txtMedStaffName);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDoctorFilter);
            this.Controls.Add(this.dGAppointment);
            this.Controls.Add(this.txtPatIDSet);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewAppointmentForm";
            this.Text = "NewAppointmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewAppointmentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dGAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label txtPatIDSet;
        private System.Windows.Forms.DataGridView dGAppointment;
        private System.Windows.Forms.ComboBox cbxDoctorFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label txtMedStaffName;
    }
}