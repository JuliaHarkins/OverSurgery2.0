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
    public partial class MedicalStaff : Form
    {
        public MedicalStaff()
        {
            InitializeComponent();
        }

        private void lb_notes_Click(object sender, EventArgs e)
        {

        }

        private void btn_addPerscription_Click(object sender, EventArgs e)
        {
            new AddPrescription();
        }

        private void MedicalStaff_Load(object sender, EventArgs e)
        {

        }

        private void btn_extRequest_Click(object sender, EventArgs e)
        {

        }

        private void lb_MedHistory_Click(object sender, EventArgs e)
        {

        }

        private void lb_appList_Click(object sender, EventArgs e)
        {

        }

        private void dgv_medicalHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_CurrentNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_saveNotes_Click(object sender, EventArgs e)
        {

        }

        private void btn_nextPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
