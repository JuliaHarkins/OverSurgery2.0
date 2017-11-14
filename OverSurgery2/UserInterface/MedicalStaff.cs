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
    public partial class MedicalStaffFrom : Form
    {
        MetaLayer ml = MetaLayer.Instance();
        MedicalStaff m_currentUser;
        BindingSource AppointmentBinding;
        List<Appointment> appointments;
        public MedicalStaffFrom(MedicalStaff p_currentUser)
        {
            m_currentUser = p_currentUser;
            InitializeComponent();
        }

        private void MedicalStaff_Load(object sender, EventArgs e)
        {
            AppointmentBinding = new BindingSource();
            appointments = ml.GetStaffAppointments(Convert.ToInt16(m_currentUser.MedicalStaffID));
            foreach(Appointment a in appointments)
            {
                a.SetNameDisplay();
            }
            grd_AppointmentList.Columns["ForeNameDisplay"].HeaderText = "Forename";
            grd_AppointmentList.Columns["SurNameDisplay"].HeaderText = "Surname";
            grd_AppointmentList.Columns["AppointmentID"].Visible = false;
            grd_AppointmentList.RowHeadersVisible = false;
            grd_AppointmentList.Columns["MedicalStaffID"].Visible = false;
            grd_AppointmentList.Columns["PatientID"].Visible = false;
            grd_AppointmentList.Columns["AppDate"].Visible = false;
            grd_AppointmentList.Columns["AppAttend"].Visible = false;
            grd_AppointmentList.DataSource = AppointmentBinding.DataSource = appointments;
            this.Text = "Logged in: " + m_currentUser.Forename + " " + m_currentUser.Surname;
            //name, last name, time, notes, DOB
            



        }

        private void lb_notes_Click(object sender, EventArgs e)
        {

        }

        private void btn_addPerscription_Click(object sender, EventArgs e)
        {
            new AddPrescription();
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
            //ml.GetStaffAppointments();
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

        private void grd_AppointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
