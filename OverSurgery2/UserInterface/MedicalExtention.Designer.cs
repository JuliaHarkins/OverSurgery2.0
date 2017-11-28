namespace OverSurgery2.UserInterface
{
    partial class MedicalExtention
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
            this.lst_extention = new System.Windows.Forms.ListBox();
            this.lb_extentions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_extention
            // 
            this.lst_extention.FormattingEnabled = true;
            this.lst_extention.Location = new System.Drawing.Point(12, 37);
            this.lst_extention.Name = "lst_extention";
            this.lst_extention.Size = new System.Drawing.Size(287, 173);
            this.lst_extention.TabIndex = 0;
            this.lst_extention.SelectedIndexChanged += new System.EventHandler(this.lst_extention_SelectedIndexChanged);
            // 
            // lb_extentions
            // 
            this.lb_extentions.AutoSize = true;
            this.lb_extentions.Location = new System.Drawing.Point(13, 21);
            this.lb_extentions.Name = "lb_extentions";
            this.lb_extentions.Size = new System.Drawing.Size(56, 13);
            this.lb_extentions.TabIndex = 1;
            this.lb_extentions.Text = "Extentions";
            // 
            // MedicalExtention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 251);
            this.Controls.Add(this.lb_extentions);
            this.Controls.Add(this.lst_extention);
            this.Name = "MedicalExtention";
            this.Text = "MedicalExtention";
            this.Load += new System.EventHandler(this.MedicalExtention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_extention;
        private System.Windows.Forms.Label lb_extentions;
    }
}