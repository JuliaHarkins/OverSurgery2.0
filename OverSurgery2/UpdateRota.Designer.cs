namespace OverSurgery2
{
    partial class UpdateRota
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
            this.staffSelected = new System.Windows.Forms.Label();
            this.CurrentSchedule = new System.Windows.Forms.GroupBox();
            this.newSchedule = new System.Windows.Forms.GroupBox();
            this.currentScheduleDisp = new System.Windows.Forms.Label();
            this.Chk_Mon = new System.Windows.Forms.CheckBox();
            this.Chk_Tue = new System.Windows.Forms.CheckBox();
            this.Chk_Thur = new System.Windows.Forms.CheckBox();
            this.Chk_Wed = new System.Windows.Forms.CheckBox();
            this.Chk_Fri = new System.Windows.Forms.CheckBox();
            this.UpdateSubmit = new System.Windows.Forms.Button();
            this.UpdateCancel = new System.Windows.Forms.Button();
            this.CurrentSchedule.SuspendLayout();
            this.newSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Selected : ";
            // 
            // staffSelected
            // 
            this.staffSelected.AutoSize = true;
            this.staffSelected.Location = new System.Drawing.Point(47, 42);
            this.staffSelected.Name = "staffSelected";
            this.staffSelected.Size = new System.Drawing.Size(88, 17);
            this.staffSelected.TabIndex = 1;
            this.staffSelected.Text = "[Select Staff]";
            // 
            // CurrentSchedule
            // 
            this.CurrentSchedule.Controls.Add(this.currentScheduleDisp);
            this.CurrentSchedule.Location = new System.Drawing.Point(50, 93);
            this.CurrentSchedule.Name = "CurrentSchedule";
            this.CurrentSchedule.Size = new System.Drawing.Size(331, 335);
            this.CurrentSchedule.TabIndex = 2;
            this.CurrentSchedule.TabStop = false;
            this.CurrentSchedule.Text = "Current Schedule";
            // 
            // newSchedule
            // 
            this.newSchedule.Controls.Add(this.Chk_Fri);
            this.newSchedule.Controls.Add(this.Chk_Thur);
            this.newSchedule.Controls.Add(this.Chk_Wed);
            this.newSchedule.Controls.Add(this.Chk_Tue);
            this.newSchedule.Controls.Add(this.Chk_Mon);
            this.newSchedule.Location = new System.Drawing.Point(473, 93);
            this.newSchedule.Name = "newSchedule";
            this.newSchedule.Size = new System.Drawing.Size(327, 335);
            this.newSchedule.TabIndex = 3;
            this.newSchedule.TabStop = false;
            this.newSchedule.Text = "New Schedule";
            // 
            // currentScheduleDisp
            // 
            this.currentScheduleDisp.AutoSize = true;
            this.currentScheduleDisp.Location = new System.Drawing.Point(19, 41);
            this.currentScheduleDisp.Name = "currentScheduleDisp";
            this.currentScheduleDisp.Size = new System.Drawing.Size(113, 17);
            this.currentScheduleDisp.TabIndex = 0;
            this.currentScheduleDisp.Text = "[Current Display]";
            // 
            // Chk_Mon
            // 
            this.Chk_Mon.AutoSize = true;
            this.Chk_Mon.Location = new System.Drawing.Point(7, 41);
            this.Chk_Mon.Name = "Chk_Mon";
            this.Chk_Mon.Size = new System.Drawing.Size(80, 21);
            this.Chk_Mon.TabIndex = 0;
            this.Chk_Mon.Text = "Monday";
            this.Chk_Mon.UseVisualStyleBackColor = true;
            // 
            // Chk_Tue
            // 
            this.Chk_Tue.AutoSize = true;
            this.Chk_Tue.Location = new System.Drawing.Point(7, 77);
            this.Chk_Tue.Name = "Chk_Tue";
            this.Chk_Tue.Size = new System.Drawing.Size(85, 21);
            this.Chk_Tue.TabIndex = 1;
            this.Chk_Tue.Text = "Tuesday";
            this.Chk_Tue.UseVisualStyleBackColor = true;
            // 
            // Chk_Thur
            // 
            this.Chk_Thur.AutoSize = true;
            this.Chk_Thur.Location = new System.Drawing.Point(7, 149);
            this.Chk_Thur.Name = "Chk_Thur";
            this.Chk_Thur.Size = new System.Drawing.Size(90, 21);
            this.Chk_Thur.TabIndex = 3;
            this.Chk_Thur.Text = "Thursday";
            this.Chk_Thur.UseVisualStyleBackColor = true;
            // 
            // Chk_Wed
            // 
            this.Chk_Wed.AutoSize = true;
            this.Chk_Wed.Location = new System.Drawing.Point(7, 113);
            this.Chk_Wed.Name = "Chk_Wed";
            this.Chk_Wed.Size = new System.Drawing.Size(105, 21);
            this.Chk_Wed.TabIndex = 2;
            this.Chk_Wed.Text = "Wednesday";
            this.Chk_Wed.UseVisualStyleBackColor = true;
            // 
            // Chk_Fri
            // 
            this.Chk_Fri.AutoSize = true;
            this.Chk_Fri.Location = new System.Drawing.Point(7, 185);
            this.Chk_Fri.Name = "Chk_Fri";
            this.Chk_Fri.Size = new System.Drawing.Size(69, 21);
            this.Chk_Fri.TabIndex = 4;
            this.Chk_Fri.Text = "Friday";
            this.Chk_Fri.UseVisualStyleBackColor = true;
            // 
            // UpdateSubmit
            // 
            this.UpdateSubmit.Location = new System.Drawing.Point(480, 435);
            this.UpdateSubmit.Name = "UpdateSubmit";
            this.UpdateSubmit.Size = new System.Drawing.Size(75, 23);
            this.UpdateSubmit.TabIndex = 4;
            this.UpdateSubmit.Text = "Submit";
            this.UpdateSubmit.UseVisualStyleBackColor = true;
            this.UpdateSubmit.Click += new System.EventHandler(this.UpdateSubmit_Click);
            // 
            // UpdateCancel
            // 
            this.UpdateCancel.Location = new System.Drawing.Point(50, 434);
            this.UpdateCancel.Name = "UpdateCancel";
            this.UpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.UpdateCancel.TabIndex = 5;
            this.UpdateCancel.Text = "Cancel";
            this.UpdateCancel.UseVisualStyleBackColor = true;
            this.UpdateCancel.Click += new System.EventHandler(this.UpdateCancel_Click);
            // 
            // UpdateRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 510);
            this.Controls.Add(this.UpdateCancel);
            this.Controls.Add(this.UpdateSubmit);
            this.Controls.Add(this.newSchedule);
            this.Controls.Add(this.CurrentSchedule);
            this.Controls.Add(this.staffSelected);
            this.Controls.Add(this.label1);
            this.Name = "UpdateRota";
            this.Text = "UpdateRota";
            this.CurrentSchedule.ResumeLayout(false);
            this.CurrentSchedule.PerformLayout();
            this.newSchedule.ResumeLayout(false);
            this.newSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label staffSelected;
        private System.Windows.Forms.GroupBox CurrentSchedule;
        private System.Windows.Forms.Label currentScheduleDisp;
        private System.Windows.Forms.GroupBox newSchedule;
        private System.Windows.Forms.CheckBox Chk_Fri;
        private System.Windows.Forms.CheckBox Chk_Thur;
        private System.Windows.Forms.CheckBox Chk_Wed;
        private System.Windows.Forms.CheckBox Chk_Tue;
        private System.Windows.Forms.CheckBox Chk_Mon;
        private System.Windows.Forms.Button UpdateSubmit;
        private System.Windows.Forms.Button UpdateCancel;
    }
}