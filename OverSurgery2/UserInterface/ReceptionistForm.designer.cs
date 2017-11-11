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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AppointmentsTab = new System.Windows.Forms.TabPage();
            this.DataGridAppointments = new System.Windows.Forms.DataGridView();
            this.PatientsTab = new System.Windows.Forms.TabPage();
            this.btn_ViewAllPatients = new System.Windows.Forms.Button();
            this.lbl_SearchForPatient = new System.Windows.Forms.Label();
            this.txt_SearchForename = new System.Windows.Forms.TextBox();
            this.txt_SearchSurname = new System.Windows.Forms.TextBox();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.btn_NewPatient = new System.Windows.Forms.Button();
            this.DataGridPatients = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppointments)).BeginInit();
            this.PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.Location = new System.Drawing.Point(875, 389);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(56, 19);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 372);
            this.tabControl1.TabIndex = 1;
            // 
            // AppointmentsTab
            // 
            this.AppointmentsTab.Controls.Add(this.button1);
            this.AppointmentsTab.Controls.Add(this.label1);
            this.AppointmentsTab.Controls.Add(this.textBox1);
            this.AppointmentsTab.Controls.Add(this.textBox2);
            this.AppointmentsTab.Controls.Add(this.button2);
            this.AppointmentsTab.Controls.Add(this.button3);
            this.AppointmentsTab.Controls.Add(this.DataGridAppointments);
            this.AppointmentsTab.Location = new System.Drawing.Point(4, 22);
            this.AppointmentsTab.Name = "AppointmentsTab";
            this.AppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTab.Size = new System.Drawing.Size(911, 346);
            this.AppointmentsTab.TabIndex = 0;
            this.AppointmentsTab.Text = "Appointments";
            this.AppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // DataGridAppointments
            // 
            this.DataGridAppointments.AllowUserToAddRows = false;
            this.DataGridAppointments.AllowUserToDeleteRows = false;
            this.DataGridAppointments.AllowUserToResizeColumns = false;
            this.DataGridAppointments.AllowUserToResizeRows = false;
            this.DataGridAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAppointments.Location = new System.Drawing.Point(6, 30);
            this.DataGridAppointments.Name = "DataGridAppointments";
            this.DataGridAppointments.ReadOnly = true;
            this.DataGridAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridAppointments.Size = new System.Drawing.Size(899, 287);
            this.DataGridAppointments.TabIndex = 0;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.btn_ViewAllPatients);
            this.PatientsTab.Controls.Add(this.lbl_SearchForPatient);
            this.PatientsTab.Controls.Add(this.txt_SearchForename);
            this.PatientsTab.Controls.Add(this.txt_SearchSurname);
            this.PatientsTab.Controls.Add(this.btn_SearchPatient);
            this.PatientsTab.Controls.Add(this.btn_NewPatient);
            this.PatientsTab.Controls.Add(this.DataGridPatients);
            this.PatientsTab.Location = new System.Drawing.Point(4, 22);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTab.Size = new System.Drawing.Size(911, 346);
            this.PatientsTab.TabIndex = 1;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // btn_ViewAllPatients
            // 
            this.btn_ViewAllPatients.Location = new System.Drawing.Point(6, 4);
            this.btn_ViewAllPatients.Name = "btn_ViewAllPatients";
            this.btn_ViewAllPatients.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewAllPatients.TabIndex = 7;
            this.btn_ViewAllPatients.Text = "View All";
            this.btn_ViewAllPatients.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchForPatient
            // 
            this.lbl_SearchForPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SearchForPatient.AutoSize = true;
            this.lbl_SearchForPatient.Location = new System.Drawing.Point(513, 9);
            this.lbl_SearchForPatient.Name = "lbl_SearchForPatient";
            this.lbl_SearchForPatient.Size = new System.Drawing.Size(95, 13);
            this.lbl_SearchForPatient.TabIndex = 6;
            this.lbl_SearchForPatient.Text = "Search for Patient:";
            // 
            // txt_SearchForename
            // 
            this.txt_SearchForename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchForename.Location = new System.Drawing.Point(614, 6);
            this.txt_SearchForename.Name = "txt_SearchForename";
            this.txt_SearchForename.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchForename.TabIndex = 5;
            this.txt_SearchForename.Text = "Forename";
            this.txt_SearchForename.Enter += new System.EventHandler(this.txt_SearchForename_Enter);
            this.txt_SearchForename.Leave += new System.EventHandler(this.txt_SearchForename_Leave);
            // 
            // txt_SearchSurname
            // 
            this.txt_SearchSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchSurname.Location = new System.Drawing.Point(720, 6);
            this.txt_SearchSurname.Name = "txt_SearchSurname";
            this.txt_SearchSurname.Size = new System.Drawing.Size(100, 20);
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
            this.btn_SearchPatient.Size = new System.Drawing.Size(80, 19);
            this.btn_SearchPatient.TabIndex = 3;
            this.btn_SearchPatient.Text = "Search";
            this.btn_SearchPatient.UseVisualStyleBackColor = true;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // btn_NewPatient
            // 
            this.btn_NewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NewPatient.Location = new System.Drawing.Point(5, 321);
            this.btn_NewPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewPatient.Name = "btn_NewPatient";
            this.btn_NewPatient.Size = new System.Drawing.Size(80, 19);
            this.btn_NewPatient.TabIndex = 2;
            this.btn_NewPatient.Text = "New Patient";
            this.btn_NewPatient.UseVisualStyleBackColor = true;
            this.btn_NewPatient.Click += new System.EventHandler(this.btn_NewPatient_Click);
            // 
            // DataGridPatients
            // 
            this.DataGridPatients.AllowUserToAddRows = false;
            this.DataGridPatients.AllowUserToDeleteRows = false;
            this.DataGridPatients.AllowUserToResizeColumns = false;
            this.DataGridPatients.AllowUserToResizeRows = false;
            this.DataGridPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPatients.Location = new System.Drawing.Point(6, 30);
            this.DataGridPatients.Name = "DataGridPatients";
            this.DataGridPatients.ReadOnly = true;
            this.DataGridPatients.Size = new System.Drawing.Size(899, 286);
            this.DataGridPatients.TabIndex = 1;
            this.DataGridPatients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridPatients_CellMouseClick);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reload.Location = new System.Drawing.Point(815, 389);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(56, 19);
            this.btn_Reload.TabIndex = 4;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search for Patient:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(614, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Forename";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(720, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Surname";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(825, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(5, 322);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 19);
            this.button3.TabIndex = 8;
            this.button3.Text = "New Patient";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(942, 419);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Logout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.AppointmentsTab.ResumeLayout(false);
            this.AppointmentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppointments)).EndInit();
            this.PatientsTab.ResumeLayout(false);
            this.PatientsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AppointmentsTab;
        private System.Windows.Forms.TabPage PatientsTab;
        private System.Windows.Forms.DataGridView DataGridAppointments;
        private System.Windows.Forms.DataGridView DataGridPatients;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button btn_NewPatient;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.TextBox txt_SearchForename;
        private System.Windows.Forms.TextBox txt_SearchSurname;
        private System.Windows.Forms.Label lbl_SearchForPatient;
        private System.Windows.Forms.Button btn_ViewAllPatients;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}