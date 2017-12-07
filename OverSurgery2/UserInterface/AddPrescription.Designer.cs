namespace OverSurgery2
{
    partial class AddPrescription
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
            this.lb_patient = new System.Windows.Forms.Label();
            this.btn_savePrescription = new System.Windows.Forms.Button();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lst_medication = new System.Windows.Forms.ListView();
            this.dtp_dateOfNextExtention = new System.Windows.Forms.DateTimePicker();
            this.cb_extenable = new System.Windows.Forms.CheckBox();
            this.lb_dateOfNextIssue = new System.Windows.Forms.Label();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(24, 18);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(132, 20);
            this.lb_patient.TabIndex = 2;
            this.lb_patient.Text = "Prescription For : ";
            // 
            // btn_savePrescription
            // 
            this.btn_savePrescription.Location = new System.Drawing.Point(494, 187);
            this.btn_savePrescription.Name = "btn_savePrescription";
            this.btn_savePrescription.Size = new System.Drawing.Size(142, 23);
            this.btn_savePrescription.TabIndex = 3;
            this.btn_savePrescription.Text = "Save Prescription";
            this.btn_savePrescription.UseVisualStyleBackColor = true;
            this.btn_savePrescription.Click += new System.EventHandler(this.btn_savePrescription_Click);
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(406, 57);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(101, 13);
            this.lb_amount.TabIndex = 5;
            this.lb_amount.Text = "Prescription Amount";
            
            // 
            // lst_medication
            // 
            this.lst_medication.Location = new System.Drawing.Point(28, 55);
            this.lst_medication.MultiSelect = false;
            this.lst_medication.Name = "lst_medication";
            this.lst_medication.Size = new System.Drawing.Size(364, 155);
            this.lst_medication.TabIndex = 8;
            this.lst_medication.UseCompatibleStateImageBehavior = false;
            this.lst_medication.View = System.Windows.Forms.View.Details;
            // 
            // dtp_dateOfNextExtention
            // 
            this.dtp_dateOfNextExtention.Location = new System.Drawing.Point(409, 136);
            this.dtp_dateOfNextExtention.Name = "dtp_dateOfNextExtention";
            this.dtp_dateOfNextExtention.Size = new System.Drawing.Size(227, 20);
            this.dtp_dateOfNextExtention.TabIndex = 12;
            // 
            // cb_extenable
            // 
            this.cb_extenable.AutoSize = true;
            this.cb_extenable.Location = new System.Drawing.Point(409, 100);
            this.cb_extenable.Name = "cb_extenable";
            this.cb_extenable.Size = new System.Drawing.Size(73, 17);
            this.cb_extenable.TabIndex = 14;
            this.cb_extenable.Text = "Extenable";
            this.cb_extenable.UseVisualStyleBackColor = true;
            this.cb_extenable.CheckedChanged += new System.EventHandler(this.cb_extenable_CheckedChanged);
            // 
            // lb_dateOfNextIssue
            // 
            this.lb_dateOfNextIssue.AutoSize = true;
            this.lb_dateOfNextIssue.Location = new System.Drawing.Point(406, 120);
            this.lb_dateOfNextIssue.Name = "lb_dateOfNextIssue";
            this.lb_dateOfNextIssue.Size = new System.Drawing.Size(97, 13);
            this.lb_dateOfNextIssue.TabIndex = 15;
            this.lb_dateOfNextIssue.Text = "Date Of Next Issue";
            // 
            // nud_amount
            // 
            this.nud_amount.Location = new System.Drawing.Point(513, 55);
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(123, 20);
            this.nud_amount.TabIndex = 16;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 226);
            this.Controls.Add(this.nud_amount);
            this.Controls.Add(this.lb_dateOfNextIssue);
            this.Controls.Add(this.cb_extenable);
            this.Controls.Add(this.dtp_dateOfNextExtention);
            this.Controls.Add(this.lst_medication);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.btn_savePrescription);
            this.Controls.Add(this.lb_patient);
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Button btn_savePrescription;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.ListView lst_medication;
        private System.Windows.Forms.DateTimePicker dtp_dateOfNextExtention;
        private System.Windows.Forms.CheckBox cb_extenable;
        private System.Windows.Forms.Label lb_dateOfNextIssue;
        private System.Windows.Forms.NumericUpDown nud_amount;
    }
}