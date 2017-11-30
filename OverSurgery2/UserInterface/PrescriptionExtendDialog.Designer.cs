namespace OverSurgery2
{
    partial class PrescriptionExtendDialog
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
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.btn_Extend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(21, 19);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(180, 26);
            this.txt_Reason.TabIndex = 2;
            // 
            // btn_Extend
            // 
            this.btn_Extend.Location = new System.Drawing.Point(208, 15);
            this.btn_Extend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Extend.Name = "btn_Extend";
            this.btn_Extend.Size = new System.Drawing.Size(112, 35);
            this.btn_Extend.TabIndex = 1;
            this.btn_Extend.Text = "button1";
            this.btn_Extend.UseVisualStyleBackColor = true;
            this.btn_Extend.Click += new System.EventHandler(this.btn_Extend_Click);
            // 
            // PrescriptionExtendDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 98);
            this.Controls.Add(this.txt_Reason);
            this.Controls.Add(this.btn_Extend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrescriptionExtendDialog";
            this.Text = "PrescriptionExtendDialog";
            this.Load += new System.EventHandler(this.PrescriptionExtendDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Button btn_Extend;
    }
}