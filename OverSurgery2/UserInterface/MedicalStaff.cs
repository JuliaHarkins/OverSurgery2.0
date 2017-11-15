using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * This form is from all medical staff allowing them to prefrom 
 * their dayly functuions while creating and updating records.
 * 
 * Last Updated : 15/11/17
 * By: J
 */

namespace OverSurgery2
{
    public partial class MedicalStaffForm : Form
    {
        MetaLayer ml = MetaLayer.Instance();
        BindingSource AppointmentBinding;
        List<Appointment> appointments;
        MedicalStaff m_currentUser;
        int AppointmentListCounter;

        public MedicalStaffForm(Staff p_currentUser)
        {

            m_currentUser = ml.GetMedicalStaffByStaffID(p_currentUser.StaffID) as MedicalStaff;
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
            if (AppointmentListCounter < grd_AppointmentList.Rows.Count)
            {
                grd_AppointmentList.Rows[AppointmentListCounter].Selected = true;
                AppointmentListCounter++;

            }


        }

        private void grd_AppointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
