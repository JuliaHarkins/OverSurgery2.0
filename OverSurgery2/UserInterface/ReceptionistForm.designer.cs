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
            this.DataGridPatients = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btn_Logout.Location = new System.Drawing.Point(875, 391);
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
            this.tabControl1.Size = new System.Drawing.Size(919, 374);
            this.tabControl1.TabIndex = 1;
            // 
            // AppointmentsTab
            // 
            this.AppointmentsTab.Controls.Add(this.DataGridAppointments);
            this.AppointmentsTab.Location = new System.Drawing.Point(4, 22);
            this.AppointmentsTab.Name = "AppointmentsTab";
            this.AppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTab.Size = new System.Drawing.Size(911, 348);
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
            this.DataGridAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAppointments.Location = new System.Drawing.Point(6, 6);
            this.DataGridAppointments.Name = "DataGridAppointments";
            this.DataGridAppointments.ReadOnly = true;
            this.DataGridAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridAppointments.Size = new System.Drawing.Size(899, 336);
            this.DataGridAppointments.TabIndex = 0;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.DataGridPatients);
            this.PatientsTab.Location = new System.Drawing.Point(4, 22);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTab.Size = new System.Drawing.Size(911, 348);
            this.PatientsTab.TabIndex = 1;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // DataGridPatients
            // 
            this.DataGridPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPatients.Location = new System.Drawing.Point(6, 6);
            this.DataGridPatients.Name = "DataGridPatients";
            this.DataGridPatients.Size = new System.Drawing.Size(899, 336);
            this.DataGridPatients.TabIndex = 1;
            this.DataGridPatients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridPatients_CellMouseClick);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(OverSurgery2.Patient);
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(942, 421);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Logout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.AppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppointments)).EndInit();
            this.PatientsTab.ResumeLayout(false);
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
    }
}