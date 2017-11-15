namespace OverSurgery2
{
    partial class MedicalStaffForm
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
            this.txt_CurrentNotes = new System.Windows.Forms.ListBox();
            this.dgv_medicalHistory = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_appnotes = new System.Windows.Forms.Label();
            this.btn_addPrescription = new System.Windows.Forms.Button();
            this.btn_saveNotes = new System.Windows.Forms.Button();
            this.grd_AppointmentList = new System.Windows.Forms.DataGridView();
            this.btn_nextPatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_appList = new System.Windows.Forms.Label();
            this.lb_MedHistory = new System.Windows.Forms.Label();
            this.btn_extRequest = new System.Windows.Forms.Button();
            this.btn_previousPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CurrentNotes
            // 
            this.txt_CurrentNotes.FormattingEnabled = true;
            this.txt_CurrentNotes.Location = new System.Drawing.Point(15, 225);
            this.txt_CurrentNotes.Name = "txt_CurrentNotes";
            this.txt_CurrentNotes.Size = new System.Drawing.Size(830, 160);
            this.txt_CurrentNotes.TabIndex = 3;
            this.txt_CurrentNotes.SelectedIndexChanged += new System.EventHandler(this.txt_CurrentNotes_SelectedIndexChanged);
            // 
            // dgv_medicalHistory
            // 
            this.dgv_medicalHistory.AllowUserToAddRows = false;
            this.dgv_medicalHistory.AllowUserToDeleteRows = false;
            this.dgv_medicalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_medicalHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_medicalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.notes,
            this.prescriptions});
            this.dgv_medicalHistory.Location = new System.Drawing.Point(12, 435);
            this.dgv_medicalHistory.Name = "dgv_medicalHistory";
            this.dgv_medicalHistory.ReadOnly = true;
            this.dgv_medicalHistory.Size = new System.Drawing.Size(960, 280);
            this.dgv_medicalHistory.TabIndex = 8;
            this.dgv_medicalHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_medicalHistory_CellContentClick);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 55;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 60;
            // 
            // prescriptions
            // 
            this.prescriptions.HeaderText = "Prescriptions";
            this.prescriptions.Name = "prescriptions";
            this.prescriptions.ReadOnly = true;
            this.prescriptions.Width = 92;
            // 
            // lb_appnotes
            // 
            this.lb_appnotes.AutoSize = true;
            this.lb_appnotes.Location = new System.Drawing.Point(12, 209);
            this.lb_appnotes.Name = "lb_appnotes";
            this.lb_appnotes.Size = new System.Drawing.Size(97, 13);
            this.lb_appnotes.TabIndex = 9;
            this.lb_appnotes.Text = "Appointment Notes";
            this.lb_appnotes.Click += new System.EventHandler(this.lb_notes_Click);
            // 
            // btn_addPrescription
            // 
            this.btn_addPrescription.Location = new System.Drawing.Point(12, 391);
            this.btn_addPrescription.Name = "btn_addPrescription";
            this.btn_addPrescription.Size = new System.Drawing.Size(124, 25);
            this.btn_addPrescription.TabIndex = 10;
            this.btn_addPrescription.Text = "Add Prescription";
            this.btn_addPrescription.UseVisualStyleBackColor = true;
            this.btn_addPrescription.Click += new System.EventHandler(this.btn_addPrescription_Click);
            // 
            // btn_saveNotes
            // 
            this.btn_saveNotes.Location = new System.Drawing.Point(142, 391);
            this.btn_saveNotes.Name = "btn_saveNotes";
            this.btn_saveNotes.Size = new System.Drawing.Size(124, 25);
            this.btn_saveNotes.TabIndex = 11;
            this.btn_saveNotes.Text = "Save Notes";
            this.btn_saveNotes.UseVisualStyleBackColor = true;
            this.btn_saveNotes.Click += new System.EventHandler(this.btn_saveNotes_Click);
            // 
            // grd_AppointmentList
            // 
            this.grd_AppointmentList.AllowUserToAddRows = false;
            this.grd_AppointmentList.AllowUserToDeleteRows = false;
            this.grd_AppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grd_AppointmentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd_AppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_AppointmentList.Location = new System.Drawing.Point(15, 25);
            this.grd_AppointmentList.Name = "grd_AppointmentList";
            this.grd_AppointmentList.ReadOnly = true;
            this.grd_AppointmentList.Size = new System.Drawing.Size(830, 150);
            this.grd_AppointmentList.TabIndex = 12;
            // 
            // btn_nextPatient
            // 
            this.btn_nextPatient.Location = new System.Drawing.Point(147, 181);
            this.btn_nextPatient.Name = "btn_nextPatient";
            this.btn_nextPatient.Size = new System.Drawing.Size(126, 25);
            this.btn_nextPatient.TabIndex = 13;
            this.btn_nextPatient.Text = "Next Patient";
            this.btn_nextPatient.UseVisualStyleBackColor = true;
            this.btn_nextPatient.Click += new System.EventHandler(this.btn_nextPatient_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 721);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Log Off";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_appList
            // 
            this.lb_appList.AutoSize = true;
            this.lb_appList.Location = new System.Drawing.Point(12, 9);
            this.lb_appList.Name = "lb_appList";
            this.lb_appList.Size = new System.Drawing.Size(85, 13);
            this.lb_appList.TabIndex = 15;
            this.lb_appList.Text = "Appointment List";
            this.lb_appList.Click += new System.EventHandler(this.lb_appList_Click);
            // 
            // lb_MedHistory
            // 
            this.lb_MedHistory.AutoSize = true;
            this.lb_MedHistory.Location = new System.Drawing.Point(9, 419);
            this.lb_MedHistory.Name = "lb_MedHistory";
            this.lb_MedHistory.Size = new System.Drawing.Size(79, 13);
            this.lb_MedHistory.TabIndex = 16;
            this.lb_MedHistory.Text = "Medical History";
            this.lb_MedHistory.Click += new System.EventHandler(this.lb_MedHistory_Click);
            // 
            // btn_extRequest
            // 
            this.btn_extRequest.Location = new System.Drawing.Point(12, 721);
            this.btn_extRequest.Name = "btn_extRequest";
            this.btn_extRequest.Size = new System.Drawing.Size(150, 30);
            this.btn_extRequest.TabIndex = 17;
            this.btn_extRequest.Text = "Extention Requests: ";
            this.btn_extRequest.UseVisualStyleBackColor = true;
            this.btn_extRequest.Click += new System.EventHandler(this.btn_extRequest_Click);
            // 
            // btn_previousPatient
            // 
            this.btn_previousPatient.Location = new System.Drawing.Point(15, 181);
            this.btn_previousPatient.Name = "btn_previousPatient";
            this.btn_previousPatient.Size = new System.Drawing.Size(126, 25);
            this.btn_previousPatient.TabIndex = 18;
            this.btn_previousPatient.Text = "Previous Patient";
            this.btn_previousPatient.UseVisualStyleBackColor = true;
            this.btn_previousPatient.Click += new System.EventHandler(this.btn_previousPatient_Click);
            // 
            // MedicalStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 779);
            this.Controls.Add(this.btn_previousPatient);
            this.Controls.Add(this.btn_extRequest);
            this.Controls.Add(this.lb_MedHistory);
            this.Controls.Add(this.lb_appList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nextPatient);
            this.Controls.Add(this.grd_AppointmentList);
            this.Controls.Add(this.btn_saveNotes);
            this.Controls.Add(this.btn_addPrescription);
            this.Controls.Add(this.lb_appnotes);
            this.Controls.Add(this.dgv_medicalHistory);
            this.Controls.Add(this.txt_CurrentNotes);
            this.Name = "MedicalStaffForm";
            this.Text = "Todays Appointments";
            this.Load += new System.EventHandler(this.MedicalStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox txt_CurrentNotes;
        private System.Windows.Forms.DataGridView dgv_medicalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptions;
        private System.Windows.Forms.Label lb_appnotes;
        private System.Windows.Forms.Button btn_addPrescription;
        private System.Windows.Forms.Button btn_saveNotes;
        private System.Windows.Forms.DataGridView grd_AppointmentList;
        private System.Windows.Forms.Button btn_nextPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_appList;
        private System.Windows.Forms.Label lb_MedHistory;
        private System.Windows.Forms.Button btn_extRequest;
        private System.Windows.Forms.Button btn_previousPatient;
    }
}