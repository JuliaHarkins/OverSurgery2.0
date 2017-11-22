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
            this.txtAddDosage = new System.Windows.Forms.TextBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtAddPermission = new System.Windows.Forms.TextBox();
            this.lblPermission = new System.Windows.Forms.Label();
            this.txtAddMedName = new System.Windows.Forms.TextBox();
            this.lblNameMed = new System.Windows.Forms.Label();
            this.btnRemoveMed = new System.Windows.Forms.Button();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.tabUpdateMed = new System.Windows.Forms.TabPage();
            this.txtUpdateDosage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatePermission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateMedName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateMed = new System.Windows.Forms.Button();
            this.btnSearchMed = new System.Windows.Forms.Button();
            this.txtSearchMedName = new System.Windows.Forms.TextBox();
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
            this.tabAddMed.Controls.Add(this.txtAddDosage);
            this.tabAddMed.Controls.Add(this.lblDosage);
            this.tabAddMed.Controls.Add(this.txtAddPermission);
            this.tabAddMed.Controls.Add(this.lblPermission);
            this.tabAddMed.Controls.Add(this.txtAddMedName);
            this.tabAddMed.Controls.Add(this.lblNameMed);
            this.tabAddMed.Controls.Add(this.btnAddMed);
            this.tabAddMed.Location = new System.Drawing.Point(4, 22);
            this.tabAddMed.Name = "tabAddMed";
            this.tabAddMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddMed.Size = new System.Drawing.Size(687, 380);
            this.tabAddMed.TabIndex = 1;
            this.tabAddMed.Text = "Add Med";
            this.tabAddMed.UseVisualStyleBackColor = true;
            // 
            // txtAddDosage
            // 
            this.txtAddDosage.Location = new System.Drawing.Point(219, 105);
            this.txtAddDosage.Name = "txtAddDosage";
            this.txtAddDosage.Size = new System.Drawing.Size(100, 20);
            this.txtAddDosage.TabIndex = 70;
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(169, 108);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(44, 13);
            this.lblDosage.TabIndex = 69;
            this.lblDosage.Text = "Dosage";
            // 
            // txtAddPermission
            // 
            this.txtAddPermission.Location = new System.Drawing.Point(219, 78);
            this.txtAddPermission.Name = "txtAddPermission";
            this.txtAddPermission.Size = new System.Drawing.Size(100, 20);
            this.txtAddPermission.TabIndex = 68;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Location = new System.Drawing.Point(127, 81);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(86, 13);
            this.lblPermission.TabIndex = 67;
            this.lblPermission.Text = "Permission Level";
            // 
            // txtAddMedName
            // 
            this.txtAddMedName.Location = new System.Drawing.Point(219, 51);
            this.txtAddMedName.Name = "txtAddMedName";
            this.txtAddMedName.Size = new System.Drawing.Size(100, 20);
            this.txtAddMedName.TabIndex = 66;
            // 
            // lblNameMed
            // 
            this.lblNameMed.AutoSize = true;
            this.lblNameMed.Location = new System.Drawing.Point(123, 54);
            this.lblNameMed.Name = "lblNameMed";
            this.lblNameMed.Size = new System.Drawing.Size(90, 13);
            this.lblNameMed.TabIndex = 65;
            this.lblNameMed.Text = "Medication Name";
            // 
            // btnRemoveMed
            // 
            this.btnRemoveMed.Location = new System.Drawing.Point(282, 4);
            this.btnRemoveMed.Name = "btnRemoveMed";
            this.btnRemoveMed.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveMed.TabIndex = 64;
            this.btnRemoveMed.Text = "Remove Med";
            this.btnRemoveMed.UseVisualStyleBackColor = true;
            this.btnRemoveMed.Click += new System.EventHandler(this.btnRemoveMed_Click);
            this.btnRemoveMed.MouseHover += new System.EventHandler(this.btnRemoveMed_MouseHover);
            // 
            // btnAddMed
            // 
            this.btnAddMed.Location = new System.Drawing.Point(590, 351);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(91, 23);
            this.btnAddMed.TabIndex = 0;
            this.btnAddMed.Text = "Add Med";
            this.btnAddMed.UseVisualStyleBackColor = true;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // tabUpdateMed
            // 
            this.tabUpdateMed.Controls.Add(this.txtUpdateDosage);
            this.tabUpdateMed.Controls.Add(this.label1);
            this.tabUpdateMed.Controls.Add(this.txtUpdatePermission);
            this.tabUpdateMed.Controls.Add(this.label2);
            this.tabUpdateMed.Controls.Add(this.txtUpdateMedName);
            this.tabUpdateMed.Controls.Add(this.label3);
            this.tabUpdateMed.Controls.Add(this.btnUpdateMed);
            this.tabUpdateMed.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateMed.Name = "tabUpdateMed";
            this.tabUpdateMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateMed.Size = new System.Drawing.Size(687, 380);
            this.tabUpdateMed.TabIndex = 0;
            this.tabUpdateMed.Text = "Update Med";
            this.tabUpdateMed.UseVisualStyleBackColor = true;
            // 
            // txtUpdateDosage
            // 
            this.txtUpdateDosage.Location = new System.Drawing.Point(240, 109);
            this.txtUpdateDosage.Name = "txtUpdateDosage";
            this.txtUpdateDosage.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDosage.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Dosage";
            // 
            // txtUpdatePermission
            // 
            this.txtUpdatePermission.Location = new System.Drawing.Point(240, 82);
            this.txtUpdatePermission.Name = "txtUpdatePermission";
            this.txtUpdatePermission.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePermission.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Permission Level";
            // 
            // txtUpdateMedName
            // 
            this.txtUpdateMedName.Location = new System.Drawing.Point(240, 55);
            this.txtUpdateMedName.Name = "txtUpdateMedName";
            this.txtUpdateMedName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateMedName.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Medication Name";
            // 
            // btnUpdateMed
            // 
            this.btnUpdateMed.Location = new System.Drawing.Point(590, 351);
            this.btnUpdateMed.Name = "btnUpdateMed";
            this.btnUpdateMed.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateMed.TabIndex = 2;
            this.btnUpdateMed.Text = "Update Med";
            this.btnUpdateMed.UseVisualStyleBackColor = true;
            this.btnUpdateMed.Click += new System.EventHandler(this.btnUpdateMed_Click);
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
            // txtSearchMedName
            // 
            this.txtSearchMedName.Location = new System.Drawing.Point(78, 6);
            this.txtSearchMedName.Name = "txtSearchMedName";
            this.txtSearchMedName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchMedName.TabIndex = 28;
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
            this.btnUpdateRota.Click += new System.EventHandler(this.btnUpdateRota_Click);
            // 
            // MedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSearchMed);
            this.Controls.Add(this.txtSearchMedName);
            this.Controls.Add(this.lblMedName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRota);
            this.Controls.Add(this.btnRemoveMed);
            this.Name = "MedicationForm";
            this.Text = "MedicationForm";
            this.tabControl1.ResumeLayout(false);
            this.tabAddMed.ResumeLayout(false);
            this.tabAddMed.PerformLayout();
            this.tabUpdateMed.ResumeLayout(false);
            this.tabUpdateMed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddMed;
        private System.Windows.Forms.Button btnRemoveMed;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.TabPage tabUpdateMed;
        private System.Windows.Forms.Button btnUpdateMed;
        private System.Windows.Forms.Button btnSearchMed;
        private System.Windows.Forms.TextBox txtSearchMedName;
        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateRota;
        private System.Windows.Forms.TextBox txtAddMedName;
        private System.Windows.Forms.Label lblNameMed;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.TextBox txtAddPermission;
        private System.Windows.Forms.TextBox txtAddDosage;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtUpdateDosage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdatePermission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateMedName;
        private System.Windows.Forms.Label label3;
    }
}