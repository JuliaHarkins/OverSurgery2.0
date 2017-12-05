using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery2.UserInterface
{
    public partial class MedicalStaffNewAppointmentFromConflictResolution : Form
    {
        private bool m_closeFlag = true;
        private bool CloseFlag { get { return m_closeFlag; } set { m_closeFlag = value; } }
        public string MedicalstaffName { get; set; }
        private List<string> StaffName { get; set; }
        public MedicalStaffNewAppointmentFromConflictResolution(string medicalStaffName)
        {
            InitializeComponent();
            this.Text = "Select Staff Member";
            StaffName = new List<string>();
            string[] split = medicalStaffName.Split(',');
            foreach (string name in split)
            {
                StaffName.Add(name);
            }
            PopulateStaffName();
        }

        private void PopulateStaffName()
        {
            cbxStaffName.DataSource = StaffName;
        }

        private void MedicalStaffNewAppointmentFromConflictResolution_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag)
            {
                e.Cancel = true;
            }

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            MedicalstaffName = cbxStaffName.Text;
            this.DialogResult = DialogResult.OK;
            CloseFlag = false;
        }
    }
}
