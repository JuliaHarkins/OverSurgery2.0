namespace OverSurgery2.UserInterface
{
    partial class MedicationForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddMed = new System.Windows.Forms.TabPage();
            this.btnRemoveMed = new System.Windows.Forms.Button();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.tabUpdateMed = new System.Windows.Forms.TabPage();
            this.btnRemoveMed2 = new System.Windows.Forms.Button();
            this.btnUpdateMed = new System.Windows.Forms.Button();
            this.btnSearchMed = new System.Windows.Forms.Button();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.lblMedName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateRota = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAddMed.SuspendLayout();
            this.tabUpdateMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddMed);
            this.tabControl1.Controls.Add(this.tabUpdateMed);
            this.tabControl1.Location = new System.Drawing.Point(15, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 406);
            this.tabControl1.TabIndex = 24;
            // 
            // tabAddMed
            // 
            this.tabAddMed.Controls.Add(this.btnRemoveMed);
            this.tabAddMed.Controls.Add(this.btnAddMed);
            this.tabAddMed.Location = new System.Drawing.Point(4, 22);
            this.tabAddMed.Name = "tabAddMed";
            this.tabAddMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddMed.Size = new System.Drawing.Size(687, 380);
            this.tabAddMed.TabIndex = 1;
            this.tabAddMed.Text = "Add Med";
            this.tabAddMed.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMed
            // 
            this.btnRemoveMed.Location = new System.Drawing.Point(493, 351);
            this.btnRemoveMed.Name = "btnRemoveMed";
            this.btnRemoveMed.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveMed.TabIndex = 64;
            this.btnRemoveMed.Text = "Remove Med";
            this.btnRemoveMed.UseVisualStyleBackColor = true;
            // 
            // btnAddMed
            // 
            this.btnAddMed.Location = new System.Drawing.Point(590, 351);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(91, 23);
            this.btnAddMed.TabIndex = 0;
            this.btnAddMed.Text = "Add Med";
            this.btnAddMed.UseVisualStyleBackColor = true;
            // 
            // tabUpdateMed
            // 
            this.tabUpdateMed.Controls.Add(this.btnRemoveMed2);
            this.tabUpdateMed.Controls.Add(this.btnUpdateMed);
            this.tabUpdateMed.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateMed.Name = "tabUpdateMed";
            this.tabUpdateMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateMed.Size = new System.Drawing.Size(687, 380);
            this.tabUpdateMed.TabIndex = 0;
            this.tabUpdateMed.Text = "Update Med";
            this.tabUpdateMed.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMed2
            // 
            this.btnRemoveMed2.Location = new System.Drawing.Point(493, 351);
            this.btnRemoveMed2.Name = "btnRemoveMed2";
            this.btnRemoveMed2.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveMed2.TabIndex = 1;
            this.btnRemoveMed2.Text = "Remove Med";
            this.btnRemoveMed2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMed
            // 
            this.btnUpdateMed.Location = new System.Drawing.Point(590, 351);
            this.btnUpdateMed.Name = "btnUpdateMed";
            this.btnUpdateMed.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateMed.TabIndex = 2;
            this.btnUpdateMed.Text = "Update Med";
            this.btnUpdateMed.UseVisualStyleBackColor = true;
            // 
            // btnSearchMed
            // 
            this.btnSearchMed.Location = new System.Drawing.Point(185, 4);
            this.btnSearchMed.Name = "btnSearchMed";
            this.btnSearchMed.Size = new System.Drawing.Size(91, 23);
            this.btnSearchMed.TabIndex = 29;
            this.btnSearchMed.Text = "Search Medication";
            this.btnSearchMed.UseVisualStyleBackColor = true;
            this.btnSearchMed.Click += new System.EventHandler(this.btnSearchMed_Click);
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(78, 6);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchUserName.TabIndex = 28;
            // 
            // lblMedName
            // 
            this.lblMedName.AutoSize = true;
            this.lblMedName.Location = new System.Drawing.Point(12, 9);
            this.lblMedName.Name = "lblMedName";
            this.lblMedName.Size = new System.Drawing.Size(59, 13);
            this.lblMedName.TabIndex = 27;
            this.lblMedName.Text = "Medication";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(619, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateRota
            // 
            this.btnUpdateRota.Location = new System.Drawing.Point(522, 452);
            this.btnUpdateRota.Name = "btnUpdateRota";
            this.btnUpdateRota.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateRota.TabIndex = 25;
            this.btnUpdateRota.Text = "Update Rota";
            this.btnUpdateRota.UseVisualStyleBackColor = true;
            // 
            // MedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSearchMed);
            this.Controls.Add(this.txtSearchUserName);
            this.Controls.Add(this.lblMedName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRota);
            this.Name = "MedicationForm";
            this.Text = "MedicationForm";
            this.tabControl1.ResumeLayout(false);
            this.tabAddMed.ResumeLayout(false);
            this.tabUpdateMed.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddMed;
        private System.Windows.Forms.Button btnRemoveMed;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.TabPage tabUpdateMed;
        private System.Windows.Forms.Button btnRemoveMed2;
        private System.Windows.Forms.Button btnUpdateMed;
        private System.Windows.Forms.Button btnSearchMed;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateRota;
    }
}