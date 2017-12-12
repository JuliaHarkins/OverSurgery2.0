namespace OverSurgery2
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
            this.lb_extentions = new System.Windows.Forms.Label();
            this.lst_extention = new System.Windows.Forms.ListView();
            this.btn_Extend = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_extentions
            // 
            this.lb_extentions.AutoSize = true;
            this.lb_extentions.Location = new System.Drawing.Point(12, 21);
            this.lb_extentions.Name = "lb_extentions";
            this.lb_extentions.Size = new System.Drawing.Size(56, 13);
            this.lb_extentions.TabIndex = 1;
            this.lb_extentions.Text = "Extentions";
            // 
            // lst_extention
            // 
            this.lst_extention.Location = new System.Drawing.Point(15, 37);
            this.lst_extention.Name = "lst_extention";
            this.lst_extention.Size = new System.Drawing.Size(580, 202);
            this.lst_extention.TabIndex = 2;
            this.lst_extention.UseCompatibleStateImageBehavior = false;
            this.lst_extention.View = System.Windows.Forms.View.Details;
            // 
            // btn_Extend
            // 
            this.btn_Extend.Location = new System.Drawing.Point(15, 245);
            this.btn_Extend.Name = "btn_Extend";
            this.btn_Extend.Size = new System.Drawing.Size(106, 23);
            this.btn_Extend.TabIndex = 3;
            this.btn_Extend.Text = "Extend";
            this.btn_Extend.UseVisualStyleBackColor = true;
            this.btn_Extend.Click += new System.EventHandler(this.btn_Extend_Click);
            // 
            // btn_decline
            // 
            this.btn_decline.Location = new System.Drawing.Point(127, 245);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(106, 23);
            this.btn_decline.TabIndex = 0;
            this.btn_decline.Text = "Decline";
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // MedicalExtention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 286);
            this.Controls.Add(this.btn_decline);
            this.Controls.Add(this.btn_Extend);
            this.Controls.Add(this.lst_extention);
            this.Controls.Add(this.lb_extentions);
            this.Name = "MedicalExtention";
            this.Text = "MedicalExtention";
            this.Load += new System.EventHandler(this.MedicalExtention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_extentions;
        private System.Windows.Forms.ListView lst_extention;
        private System.Windows.Forms.Button btn_Extend;
        private System.Windows.Forms.Button btn_decline;
    }
}