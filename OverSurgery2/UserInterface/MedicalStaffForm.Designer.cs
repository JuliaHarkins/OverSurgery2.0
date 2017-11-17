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
            this.lb_appnotes = new System.Windows.Forms.Label();
            this.btn_addPrescription = new System.Windows.Forms.Button();
            this.btn_saveNotes = new System.Windows.Forms.Button();
            this.dgv_AppointmentList = new System.Windows.Forms.DataGridView();
            this.btn_nextPatient = new System.Windows.Forms.Button();
            this.btn_logOff = new System.Windows.Forms.Button();
            this.lb_appList = new System.Windows.Forms.Label();
            this.lb_MedHistory = new System.Windows.Forms.Label();
            this.btn_extRequest = new System.Windows.Forms.Button();
            this.btn_previousPatient = new System.Windows.Forms.Button();
            this.lb_currentUser = new System.Windows.Forms.Label();
            this.lst_MedicalHistory = new System.Windows.Forms.ListView();
            this.col_medicalDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_medicalNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Prescriptions = new System.Windows.Forms.ListView();
            this.col_dateIssued = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_medication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MedStaff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_CurrentNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_appnotes
            // 
            this.lb_appnotes.AutoSize = true;
            this.lb_appnotes.Location = new System.Drawing.Point(9, 236);
            this.lb_appnotes.Name = "lb_appnotes";
            this.lb_appnotes.Size = new System.Drawing.Size(97, 13);
            this.lb_appnotes.TabIndex = 9;
            this.lb_appnotes.Text = "Appointment Notes";
            this.lb_appnotes.Click += new System.EventHandler(this.lb_notes_Click);
            // 
            // btn_addPrescription
            // 
            this.btn_addPrescription.Location = new System.Drawing.Point(139, 418);
            this.btn_addPrescription.Name = "btn_addPrescription";
            this.btn_addPrescription.Size = new System.Drawing.Size(124, 25);
            this.btn_addPrescription.TabIndex = 10;
            this.btn_addPrescription.Text = "Add Prescription";
            this.btn_addPrescription.UseVisualStyleBackColor = true;
            this.btn_addPrescription.Click += new System.EventHandler(this.btn_addPrescription_Click);
            // 
            // btn_saveNotes
            // 
            this.btn_saveNotes.Location = new System.Drawing.Point(9, 418);
            this.btn_saveNotes.Name = "btn_saveNotes";
            this.btn_saveNotes.Size = new System.Drawing.Size(124, 25);
            this.btn_saveNotes.TabIndex = 11;
            this.btn_saveNotes.Text = "Save Notes";
            this.btn_saveNotes.UseVisualStyleBackColor = true;
            this.btn_saveNotes.Click += new System.EventHandler(this.btn_saveNotes_Click);
            // 
            // dgv_AppointmentList
            // 
            this.dgv_AppointmentList.AllowUserToAddRows = false;
            this.dgv_AppointmentList.AllowUserToDeleteRows = false;
            this.dgv_AppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_AppointmentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_AppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AppointmentList.Location = new System.Drawing.Point(9, 52);
            this.dgv_AppointmentList.Name = "dgv_AppointmentList";
            this.dgv_AppointmentList.ReadOnly = true;
            this.dgv_AppointmentList.Size = new System.Drawing.Size(957, 150);
            this.dgv_AppointmentList.TabIndex = 12;
            this.dgv_AppointmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AppointmentList_CellContentClick);
            // 
            // btn_nextPatient
            // 
            this.btn_nextPatient.Location = new System.Drawing.Point(144, 208);
            this.btn_nextPatient.Name = "btn_nextPatient";
            this.btn_nextPatient.Size = new System.Drawing.Size(126, 25);
            this.btn_nextPatient.TabIndex = 13;
            this.btn_nextPatient.Text = "Next Patient";
            this.btn_nextPatient.UseVisualStyleBackColor = true;
            this.btn_nextPatient.Click += new System.EventHandler(this.btn_nextPatient_Click);
            // 
            // btn_logOff
            // 
            this.btn_logOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOff.Location = new System.Drawing.Point(9, 748);
            this.btn_logOff.Name = "btn_logOff";
            this.btn_logOff.Size = new System.Drawing.Size(150, 30);
            this.btn_logOff.TabIndex = 14;
            this.btn_logOff.Text = "Log Off";
            this.btn_logOff.UseVisualStyleBackColor = true;
            this.btn_logOff.Click += new System.EventHandler(this.btn_logOff_Click);
            // 
            // lb_appList
            // 
            this.lb_appList.AutoSize = true;
            this.lb_appList.Location = new System.Drawing.Point(9, 36);
            this.lb_appList.Name = "lb_appList";
            this.lb_appList.Size = new System.Drawing.Size(85, 13);
            this.lb_appList.TabIndex = 15;
            this.lb_appList.Text = "Appointment List";
            this.lb_appList.Click += new System.EventHandler(this.lb_appList_Click);
            // 
            // lb_MedHistory
            // 
            this.lb_MedHistory.AutoSize = true;
            this.lb_MedHistory.Location = new System.Drawing.Point(6, 446);
            this.lb_MedHistory.Name = "lb_MedHistory";
            this.lb_MedHistory.Size = new System.Drawing.Size(79, 13);
            this.lb_MedHistory.TabIndex = 16;
            this.lb_MedHistory.Text = "Medical History";
            this.lb_MedHistory.Click += new System.EventHandler(this.lb_MedHistory_Click);
            // 
            // btn_extRequest
            // 
            this.btn_extRequest.Location = new System.Drawing.Point(165, 748);
            this.btn_extRequest.Name = "btn_extRequest";
            this.btn_extRequest.Size = new System.Drawing.Size(150, 30);
            this.btn_extRequest.TabIndex = 17;
            this.btn_extRequest.Text = "Extention Requests: ";
            this.btn_extRequest.UseVisualStyleBackColor = true;
            this.btn_extRequest.Click += new System.EventHandler(this.btn_extRequest_Click);
            // 
            // btn_previousPatient
            // 
            this.btn_previousPatient.Location = new System.Drawing.Point(12, 208);
            this.btn_previousPatient.Name = "btn_previousPatient";
            this.btn_previousPatient.Size = new System.Drawing.Size(126, 25);
            this.btn_previousPatient.TabIndex = 18;
            this.btn_previousPatient.Text = "Previous Patient";
            this.btn_previousPatient.UseVisualStyleBackColor = true;
            this.btn_previousPatient.Click += new System.EventHandler(this.btn_previousPatient_Click);
            // 
            // lb_currentUser
            // 
            this.lb_currentUser.AutoSize = true;
            this.lb_currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_currentUser.Location = new System.Drawing.Point(12, 9);
            this.lb_currentUser.Name = "lb_currentUser";
            this.lb_currentUser.Size = new System.Drawing.Size(81, 16);
            this.lb_currentUser.TabIndex = 19;
            this.lb_currentUser.Text = "Temp name";
            this.lb_currentUser.Click += new System.EventHandler(this.lb_currentUser_Click);
            // 
            // lst_MedicalHistory
            // 
            this.lst_MedicalHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_medicalDate,
            this.col_medicalNotes});
            this.lst_MedicalHistory.Location = new System.Drawing.Point(9, 477);
            this.lst_MedicalHistory.Name = "lst_MedicalHistory";
            this.lst_MedicalHistory.Size = new System.Drawing.Size(475, 259);
            this.lst_MedicalHistory.TabIndex = 20;
            this.lst_MedicalHistory.UseCompatibleStateImageBehavior = false;
            this.lst_MedicalHistory.View = System.Windows.Forms.View.Details;
            this.lst_MedicalHistory.SelectedIndexChanged += new System.EventHandler(this.lst_MedicalHistory_SelectedIndexChanged);
            // 
            // col_medicalDate
            // 
            this.col_medicalDate.Text = "Date";
            this.col_medicalDate.Width = 97;
            // 
            // col_medicalNotes
            // 
            this.col_medicalNotes.Text = "Medical Notes";
            this.col_medicalNotes.Width = 373;
            // 
            // lst_Prescriptions
            // 
            this.lst_Prescriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_dateIssued,
            this.col_medication,
            this.col_amount,
            this.col_MedStaff});
            this.lst_Prescriptions.Location = new System.Drawing.Point(488, 477);
            this.lst_Prescriptions.Name = "lst_Prescriptions";
            this.lst_Prescriptions.Size = new System.Drawing.Size(477, 259);
            this.lst_Prescriptions.TabIndex = 21;
            this.lst_Prescriptions.UseCompatibleStateImageBehavior = false;
            this.lst_Prescriptions.View = System.Windows.Forms.View.Details;
            this.lst_Prescriptions.SelectedIndexChanged += new System.EventHandler(this.lst_Prescriptions_SelectedIndexChanged);
            // 
            // col_dateIssued
            // 
            this.col_dateIssued.Text = "Date Issued";
            this.col_dateIssued.Width = 105;
            // 
            // col_medication
            // 
            this.col_medication.Text = "Medication";
            this.col_medication.Width = 122;
            // 
            // col_amount
            // 
            this.col_amount.Text = "Amount";
            this.col_amount.Width = 101;
            // 
            // col_MedStaff
            // 
            this.col_MedStaff.Text = "Prescribed By";
            this.col_MedStaff.Width = 97;
            // 
            // txt_CurrentNotes
            // 
            this.txt_CurrentNotes.Location = new System.Drawing.Point(9, 252);
            this.txt_CurrentNotes.Multiline = true;
            this.txt_CurrentNotes.Name = "txt_CurrentNotes";
            this.txt_CurrentNotes.Size = new System.Drawing.Size(955, 160);
            this.txt_CurrentNotes.TabIndex = 22;
            // 
            // MedicalStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 783);
            this.Controls.Add(this.txt_CurrentNotes);
            this.Controls.Add(this.lst_Prescriptions);
            this.Controls.Add(this.lst_MedicalHistory);
            this.Controls.Add(this.lb_currentUser);
            this.Controls.Add(this.btn_previousPatient);
            this.Controls.Add(this.btn_extRequest);
            this.Controls.Add(this.lb_MedHistory);
            this.Controls.Add(this.lb_appList);
            this.Controls.Add(this.btn_logOff);
            this.Controls.Add(this.btn_nextPatient);
            this.Controls.Add(this.dgv_AppointmentList);
            this.Controls.Add(this.btn_saveNotes);
            this.Controls.Add(this.btn_addPrescription);
            this.Controls.Add(this.lb_appnotes);
            this.Name = "MedicalStaffForm";
            this.Text = "Todays Appointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MedicalStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_appnotes;
        private System.Windows.Forms.Button btn_addPrescription;
        private System.Windows.Forms.Button btn_saveNotes;
        private System.Windows.Forms.DataGridView dgv_AppointmentList;
        private System.Windows.Forms.Button btn_nextPatient;
        private System.Windows.Forms.Button btn_logOff;
        private System.Windows.Forms.Label lb_appList;
        private System.Windows.Forms.Label lb_MedHistory;
        private System.Windows.Forms.Button btn_extRequest;
        private System.Windows.Forms.Button btn_previousPatient;
        private System.Windows.Forms.Label lb_currentUser;
        private System.Windows.Forms.ListView lst_MedicalHistory;
        private System.Windows.Forms.ListView lst_Prescriptions;
        private System.Windows.Forms.ColumnHeader col_medicalDate;
        private System.Windows.Forms.ColumnHeader col_medicalNotes;
        private System.Windows.Forms.ColumnHeader col_dateIssued;
        private System.Windows.Forms.ColumnHeader col_medication;
        private System.Windows.Forms.ColumnHeader col_amount;
        private System.Windows.Forms.ColumnHeader col_MedStaff;
        private System.Windows.Forms.TextBox txt_CurrentNotes;
    }
}