namespace OverSurgery2.UserInterface
{
    partial class RotaSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxForename = new System.Windows.Forms.TextBox();
            this.txtBxSurname = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDispFri = new System.Windows.Forms.Label();
            this.txtDispThur = new System.Windows.Forms.Label();
            this.txtDispWed = new System.Windows.Forms.Label();
            this.txtDispTue = new System.Windows.Forms.Label();
            this.txtDispMon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dG_Suggested = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnClearDisp = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Suggested)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // txtBxForename
            // 
            this.txtBxForename.Location = new System.Drawing.Point(108, 34);
            this.txtBxForename.Name = "txtBxForename";
            this.txtBxForename.Size = new System.Drawing.Size(100, 22);
            this.txtBxForename.TabIndex = 2;
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Location = new System.Drawing.Point(108, 69);
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(100, 22);
            this.txtBxSurname.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(224, 53);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 393);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working Dates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDispFri);
            this.groupBox2.Controls.Add(this.txtDispThur);
            this.groupBox2.Controls.Add(this.txtDispWed);
            this.groupBox2.Controls.Add(this.txtDispTue);
            this.groupBox2.Controls.Add(this.txtDispMon);
            this.groupBox2.Location = new System.Drawing.Point(108, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 206);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // txtDispFri
            // 
            this.txtDispFri.AutoSize = true;
            this.txtDispFri.Location = new System.Drawing.Point(8, 175);
            this.txtDispFri.Name = "txtDispFri";
            this.txtDispFri.Size = new System.Drawing.Size(85, 17);
            this.txtDispFri.TabIndex = 4;
            this.txtDispFri.Text = "[Insert Data]";
            // 
            // txtDispThur
            // 
            this.txtDispThur.AutoSize = true;
            this.txtDispThur.Location = new System.Drawing.Point(8, 139);
            this.txtDispThur.Name = "txtDispThur";
            this.txtDispThur.Size = new System.Drawing.Size(85, 17);
            this.txtDispThur.TabIndex = 3;
            this.txtDispThur.Text = "[Insert Data]";
            // 
            // txtDispWed
            // 
            this.txtDispWed.AutoSize = true;
            this.txtDispWed.Location = new System.Drawing.Point(7, 101);
            this.txtDispWed.Name = "txtDispWed";
            this.txtDispWed.Size = new System.Drawing.Size(85, 17);
            this.txtDispWed.TabIndex = 2;
            this.txtDispWed.Text = "[Insert Data]";
            // 
            // txtDispTue
            // 
            this.txtDispTue.AutoSize = true;
            this.txtDispTue.Location = new System.Drawing.Point(7, 64);
            this.txtDispTue.Name = "txtDispTue";
            this.txtDispTue.Size = new System.Drawing.Size(85, 17);
            this.txtDispTue.TabIndex = 1;
            this.txtDispTue.Text = "[Insert Data]";
            // 
            // txtDispMon
            // 
            this.txtDispMon.AutoSize = true;
            this.txtDispMon.Location = new System.Drawing.Point(7, 25);
            this.txtDispMon.Name = "txtDispMon";
            this.txtDispMon.Size = new System.Drawing.Size(85, 17);
            this.txtDispMon.TabIndex = 0;
            this.txtDispMon.Text = "[Insert Data]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thursday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wednesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monday";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dG_Suggested);
            this.groupBox3.Location = new System.Drawing.Point(400, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 242);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suggested Staff";
            // 
            // dG_Suggested
            // 
            this.dG_Suggested.AllowUserToAddRows = false;
            this.dG_Suggested.AllowUserToDeleteRows = false;
            this.dG_Suggested.AllowUserToResizeColumns = false;
            this.dG_Suggested.AllowUserToResizeRows = false;
            this.dG_Suggested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Suggested.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.Forename,
            this.Surname});
            this.dG_Suggested.Location = new System.Drawing.Point(7, 22);
            this.dG_Suggested.Name = "dG_Suggested";
            this.dG_Suggested.ReadOnly = true;
            this.dG_Suggested.RowTemplate.Height = 24;
            this.dG_Suggested.Size = new System.Drawing.Size(427, 150);
            this.dG_Suggested.TabIndex = 0;
            this.dG_Suggested.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_Suggested_CellClick);
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // Forename
            // 
            this.Forename.HeaderText = "Forename";
            this.Forename.Name = "Forename";
            this.Forename.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(773, 492);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Exit";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClearDisp
            // 
            this.BtnClearDisp.Location = new System.Drawing.Point(636, 492);
            this.BtnClearDisp.Name = "BtnClearDisp";
            this.BtnClearDisp.Size = new System.Drawing.Size(113, 23);
            this.BtnClearDisp.TabIndex = 8;
            this.BtnClearDisp.Text = "Clear Display";
            this.BtnClearDisp.UseVisualStyleBackColor = true;
            this.BtnClearDisp.Click += new System.EventHandler(this.BtnClearDisp_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(407, 492);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(113, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update Rota";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // RotaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 528);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnClearDisp);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtBxSurname);
            this.Controls.Add(this.txtBxForename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RotaSearch";
            this.Text = "RotaSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dG_Suggested)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxForename;
        private System.Windows.Forms.TextBox txtBxSurname;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtDispFri;
        private System.Windows.Forms.Label txtDispThur;
        private System.Windows.Forms.Label txtDispWed;
        private System.Windows.Forms.Label txtDispTue;
        private System.Windows.Forms.Label txtDispMon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dG_Suggested;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnClearDisp;
        private System.Windows.Forms.Button BtnUpdate;
    }
}