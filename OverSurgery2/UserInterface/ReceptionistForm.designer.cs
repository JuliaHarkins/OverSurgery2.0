namespace OverSurgery2
{
    partial class ReceptionistForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AppointmentsTab = new System.Windows.Forms.TabPage();
            this.btn_ViewAllApp = new System.Windows.Forms.Button();
            this.lbl_SearchAppByPatient = new System.Windows.Forms.Label();
            this.txt_SearchAppForename = new System.Windows.Forms.TextBox();
            this.txt_SearchAppSurname = new System.Windows.Forms.TextBox();
            this.btn_SearchApp = new System.Windows.Forms.Button();
            this.btn_NewApp = new System.Windows.Forms.Button();
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.PatientsTab = new System.Windows.Forms.TabPage();
            this.lbl_PatientCount = new System.Windows.Forms.Label();
            this.btn_ViewAllPatients = new System.Windows.Forms.Button();
            this.lbl_SearchForPatient = new System.Windows.Forms.Label();
            this.txt_SearchForename = new System.Windows.Forms.TextBox();
            this.txt_SearchSurname = new System.Windows.Forms.TextBox();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.btn_NewPatient = new System.Windows.Forms.Button();
            this.dgv_Patients = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.AppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            this.PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(841, 526);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(86, 33);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.AppointmentsTab);
            this.tabControl1.Controls.Add(this.PatientsTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // AppointmentsTab
            // 
            this.AppointmentsTab.Controls.Add(this.btn_ViewAllApp);
            this.AppointmentsTab.Controls.Add(this.lbl_SearchAppByPatient);
            this.AppointmentsTab.Controls.Add(this.txt_SearchAppForename);
            this.AppointmentsTab.Controls.Add(this.txt_SearchAppSurname);
            this.AppointmentsTab.Controls.Add(this.btn_SearchApp);
            this.AppointmentsTab.Controls.Add(this.btn_NewApp);
            this.AppointmentsTab.Controls.Add(this.dgv_Appointments);
            this.AppointmentsTab.Location = new System.Drawing.Point(4, 29);
            this.AppointmentsTab.Name = "AppointmentsTab";
            this.AppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTab.Size = new System.Drawing.Size(911, 473);
            this.AppointmentsTab.TabIndex = 0;
            this.AppointmentsTab.Text = "Appointments";
            this.AppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // btn_ViewAllApp
            // 
            this.btn_ViewAllApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAllApp.Location = new System.Drawing.Point(6, 4);
            this.btn_ViewAllApp.Name = "btn_ViewAllApp";
            this.btn_ViewAllApp.Size = new System.Drawing.Size(75, 28);
            this.btn_ViewAllApp.TabIndex = 2;
            this.btn_ViewAllApp.Text = "View All";
            this.btn_ViewAllApp.UseVisualStyleBackColor = true;
            this.btn_ViewAllApp.Click += new System.EventHandler(this.btn_ViewAllApp_Click);
            // 
            // lbl_SearchAppByPatient
            // 
            this.lbl_SearchAppByPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SearchAppByPatient.AutoSize = true;
            this.lbl_SearchAppByPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchAppByPatient.Location = new System.Drawing.Point(352, 10);
            this.lbl_SearchAppByPatient.Name = "lbl_SearchAppByPatient";
            this.lbl_SearchAppByPatient.Size = new System.Drawing.Size(256, 20);
            this.lbl_SearchAppByPatient.TabIndex = 12;
            this.lbl_SearchAppByPatient.Text = "Search for Appointment by Patient:";
            // 
            // txt_SearchAppForename
            // 
            this.txt_SearchAppForename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchAppForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchAppForename.Location = new System.Drawing.Point(614, 7);
            this.txt_SearchAppForename.Name = "txt_SearchAppForename";
            this.txt_SearchAppForename.Size = new System.Drawing.Size(100, 26);
            this.txt_SearchAppForename.TabIndex = 3;
            this.txt_SearchAppForename.Text = "Forename";
            this.txt_SearchAppForename.Enter += new System.EventHandler(this.txt_SearchAppForename_Enter);
            this.txt_SearchAppForename.Leave += new System.EventHandler(this.txt_SearchAppForename_Leave);
            // 
            // txt_SearchAppSurname
            // 
            this.txt_SearchAppSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchAppSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchAppSurname.Location = new System.Drawing.Point(720, 7);
            this.txt_SearchAppSurname.Name = "txt_SearchAppSurname";
            this.txt_SearchAppSurname.Size = new System.Drawing.Size(100, 26);
            this.txt_SearchAppSurname.TabIndex = 4;
            this.txt_SearchAppSurname.Text = "Surname";
            this.txt_SearchAppSurname.Enter += new System.EventHandler(this.txt_SearchAppSurname_Enter);
            this.txt_SearchAppSurname.Leave += new System.EventHandler(this.txt_SearchAppSurname_Leave);
            // 
            // btn_SearchApp
            // 
            this.btn_SearchApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchApp.Location = new System.Drawing.Point(825, 8);
            this.btn_SearchApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SearchApp.Name = "btn_SearchApp";
            this.btn_SearchApp.Size = new System.Drawing.Size(80, 25);
            this.btn_SearchApp.TabIndex = 5;
            this.btn_SearchApp.Text = "Search";
            this.btn_SearchApp.UseVisualStyleBackColor = true;
            this.btn_SearchApp.Click += new System.EventHandler(this.btn_SearchApp_Click);
            // 
            // btn_NewApp
            // 
            this.btn_NewApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NewApp.Location = new System.Drawing.Point(6, 441);
            this.btn_NewApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewApp.Name = "btn_NewApp";
            this.btn_NewApp.Size = new System.Drawing.Size(144, 27);
            this.btn_NewApp.TabIndex = 7;
            this.btn_NewApp.Text = "New Appointment";
            this.btn_NewApp.UseVisualStyleBackColor = true;
            this.btn_NewApp.Click += new System.EventHandler(this.btn_NewApp_Click);
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.AllowUserToAddRows = false;
            this.dgv_Appointments.AllowUserToDeleteRows = false;
            this.dgv_Appointments.AllowUserToResizeColumns = false;
            this.dgv_Appointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Appointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Appointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Appointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Appointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.Location = new System.Drawing.Point(6, 39);
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.ReadOnly = true;
            this.dgv_Appointments.RowHeadersVisible = false;
            this.dgv_Appointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Appointments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Appointments.Size = new System.Drawing.Size(899, 397);
            this.dgv_Appointments.TabIndex = 6;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.lbl_PatientCount);
            this.PatientsTab.Controls.Add(this.btn_ViewAllPatients);
            this.PatientsTab.Controls.Add(this.lbl_SearchForPatient);
            this.PatientsTab.Controls.Add(this.txt_SearchForename);
            this.PatientsTab.Controls.Add(this.txt_SearchSurname);
            this.PatientsTab.Controls.Add(this.btn_SearchPatient);
            this.PatientsTab.Controls.Add(this.btn_NewPatient);
            this.PatientsTab.Controls.Add(this.dgv_Patients);
            this.PatientsTab.Location = new System.Drawing.Point(4, 29);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTab.Size = new System.Drawing.Size(911, 473);
            this.PatientsTab.TabIndex = 1;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // lbl_PatientCount
            // 
            this.lbl_PatientCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PatientCount.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lbl_PatientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PatientCount.Location = new System.Drawing.Point(707, 444);
            this.lbl_PatientCount.Name = "lbl_PatientCount";
            this.lbl_PatientCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_PatientCount.Size = new System.Drawing.Size(198, 20);
            this.lbl_PatientCount.TabIndex = 14;
            this.lbl_PatientCount.Text = "Number of Patients:";
            // 
            // btn_ViewAllPatients
            // 
            this.btn_ViewAllPatients.Location = new System.Drawing.Point(6, 4);
            this.btn_ViewAllPatients.Name = "btn_ViewAllPatients";
            this.btn_ViewAllPatients.Size = new System.Drawing.Size(75, 28);
            this.btn_ViewAllPatients.TabIndex = 7;
            this.btn_ViewAllPatients.Text = "View All";
            this.btn_ViewAllPatients.UseVisualStyleBackColor = true;
            this.btn_ViewAllPatients.Click += new System.EventHandler(this.btn_ViewAllPatients_Click);
            // 
            // lbl_SearchForPatient
            // 
            this.lbl_SearchForPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SearchForPatient.AutoSize = true;
            this.lbl_SearchForPatient.Location = new System.Drawing.Point(467, 10);
            this.lbl_SearchForPatient.Name = "lbl_SearchForPatient";
            this.lbl_SearchForPatient.Size = new System.Drawing.Size(141, 20);
            this.lbl_SearchForPatient.TabIndex = 6;
            this.lbl_SearchForPatient.Text = "Search for Patient:";
            // 
            // txt_SearchForename
            // 
            this.txt_SearchForename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchForename.Location = new System.Drawing.Point(614, 7);
            this.txt_SearchForename.Name = "txt_SearchForename";
            this.txt_SearchForename.Size = new System.Drawing.Size(100, 26);
            this.txt_SearchForename.TabIndex = 5;
            this.txt_SearchForename.Text = "Forename";
            this.txt_SearchForename.Enter += new System.EventHandler(this.txt_SearchForename_Enter);
            this.txt_SearchForename.Leave += new System.EventHandler(this.txt_SearchForename_Leave);
            // 
            // txt_SearchSurname
            // 
            this.txt_SearchSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchSurname.Location = new System.Drawing.Point(720, 7);
            this.txt_SearchSurname.Name = "txt_SearchSurname";
            this.txt_SearchSurname.Size = new System.Drawing.Size(100, 26);
            this.txt_SearchSurname.TabIndex = 4;
            this.txt_SearchSurname.Text = "Surname";
            this.txt_SearchSurname.Enter += new System.EventHandler(this.txt_SearchSurname_Enter);
            this.txt_SearchSurname.Leave += new System.EventHandler(this.txt_SearchSurname_Leave);
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchPatient.Location = new System.Drawing.Point(825, 7);
            this.btn_SearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(80, 26);
            this.btn_SearchPatient.TabIndex = 3;
            this.btn_SearchPatient.Text = "Search";
            this.btn_SearchPatient.UseVisualStyleBackColor = true;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // btn_NewPatient
            // 
            this.btn_NewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NewPatient.Location = new System.Drawing.Point(6, 441);
            this.btn_NewPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewPatient.Name = "btn_NewPatient";
            this.btn_NewPatient.Size = new System.Drawing.Size(132, 27);
            this.btn_NewPatient.TabIndex = 2;
            this.btn_NewPatient.Text = "New Patient";
            this.btn_NewPatient.UseVisualStyleBackColor = true;
            this.btn_NewPatient.Click += new System.EventHandler(this.btn_NewPatient_Click);
            // 
            // dgv_Patients
            // 
            this.dgv_Patients.AllowUserToAddRows = false;
            this.dgv_Patients.AllowUserToDeleteRows = false;
            this.dgv_Patients.AllowUserToResizeColumns = false;
            this.dgv_Patients.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Patients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Patients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Patients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Patients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Patients.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Patients.Location = new System.Drawing.Point(6, 38);
            this.dgv_Patients.Name = "dgv_Patients";
            this.dgv_Patients.ReadOnly = true;
            this.dgv_Patients.Size = new System.Drawing.Size(899, 398);
            this.dgv_Patients.TabIndex = 1;
            this.dgv_Patients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPatients_CellContentClick);
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.AppointmentsTab.ResumeLayout(false);
            this.AppointmentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            this.PatientsTab.ResumeLayout(false);
            this.PatientsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AppointmentsTab;
        private System.Windows.Forms.TabPage PatientsTab;
        private System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.DataGridView dgv_Patients;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button btn_NewPatient;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.TextBox txt_SearchForename;
        private System.Windows.Forms.TextBox txt_SearchSurname;
        private System.Windows.Forms.Label lbl_SearchForPatient;
        private System.Windows.Forms.Button btn_ViewAllPatients;
        private System.Windows.Forms.Button btn_ViewAllApp;
        private System.Windows.Forms.Label lbl_SearchAppByPatient;
        private System.Windows.Forms.TextBox txt_SearchAppForename;
        private System.Windows.Forms.TextBox txt_SearchAppSurname;
        private System.Windows.Forms.Button btn_SearchApp;
        private System.Windows.Forms.Button btn_NewApp;
        private System.Windows.Forms.Label lbl_PatientCount;
    }
}