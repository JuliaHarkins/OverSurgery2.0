namespace OverSurgery2.UserInterface
{
    partial class MedicalStaffNewAppointmentFromConflictResolution
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
            this.cbxStaffName = new System.Windows.Forms.ComboBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cbxStaffName
            // 
            this.cbxStaffName.FormattingEnabled = true;
            this.cbxStaffName.Location = new System.Drawing.Point(37, 66);
            this.cbxStaffName.Name = "cbxStaffName";
            this.cbxStaffName.Size = new System.Drawing.Size(220, 24);
            this.cbxStaffName.TabIndex = 0;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(37, 249);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(106, 29);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Staff Member";
            // 
            // MedicalStaffNewAppointmentFromConflictResolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.cbxStaffName);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedicalStaffNewAppointmentFromConflictResolution";
            this.Text = "MedicalStaffNewAppointmentFromConflictResolution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedicalStaffNewAppointmentFromConflictResolution_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStaffName;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}