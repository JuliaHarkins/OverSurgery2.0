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
        Doctor m_currentDoctor;
        int AppointmentListCounter;
        Patient m_selectedPatient;

        public MedicalStaffForm(Staff p_currentUser)
        {
            if(m_currentUser.GetType() == typeof(Doctor))
            {
                m_currentDoctor = p_currentUser as Doctor;
            }
            else if(m_currentUser.GetType() == typeof(MedicalStaff))
            {
                m_currentUser = p_currentUser as MedicalStaff;
            }
            InitializeComponent();
            this.ShowDialog();
        }


        private void MedicalStaff_Load(object sender, EventArgs e)
        {
            if(m_currentUser.GetType() == typeof(MedicalStaff))
            {
                var tempLoc = btn_addPrescription.Location;
                btn_addPrescription.Visible = false;
                btn_saveNotes.Location = tempLoc;
            }
            AppointmentBinding = new BindingSource();
            appointments = ml.GetStaffAppointments(Convert.ToInt16(m_currentUser.MedicalStaffID));
            foreach(Appointment a in appointments)
            {
                a.SetNameDisplay();
            }
            grd_AppointmentList.DataSource = AppointmentBinding.DataSource = appointments;
            grd_AppointmentList.Columns["ForeNameDisplay"].HeaderText = "Forename";
            grd_AppointmentList.Columns["SurNameDisplay"].HeaderText = "Surname";
            grd_AppointmentList.Columns["AppointmentID"].Visible = false;
            grd_AppointmentList.RowHeadersVisible = false;
            grd_AppointmentList.Columns["MedicalStaffID"].Visible = false;
            grd_AppointmentList.Columns["PatientID"].Visible = false;
            grd_AppointmentList.Columns["AppDate"].Visible = false;
            grd_AppointmentList.Columns["AppAttend"].Visible = false;
            grd_AppointmentList.Columns["AppTime"].Visible = false;
            grd_AppointmentList.Columns["TimeDisplay"].DisplayIndex = 1;
            grd_AppointmentList.Columns["TimeDisplay"].HeaderText = "Time";

            this.Text = "Logged in: " + m_currentUser.Forename + " " + m_currentUser.Surname +" - OverSurgery Management System";

            //grd_AppointmentList.Columns["PatientID"].DisplayIndex = 0;
            if (grd_AppointmentList.RowCount > 0)
            {
                AppointmentListCounter = 0;
                grd_AppointmentList.CurrentCell = grd_AppointmentList[0, AppointmentListCounter];
                grd_AppointmentList.CurrentRow.Selected = true;
            }
            
            //name, last name, time, notes, DOB
            




        }

        private void lb_notes_Click(object sender, EventArgs e)
        {

        }

        private void btn_addPrescription_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Get next patient appointment upon click of button
        /// </summary>
        /// <param name="sender">MedicalStaffForm</param>
        /// <param name="e"></param>
        private void btn_nextPatient_Click(object sender, EventArgs e)
        {
            // If current cell index less than or equals row count and current cell index is less than count of all rows
            if (grd_AppointmentList.CurrentCell.RowIndex <= grd_AppointmentList.RowCount 
                && grd_AppointmentList.CurrentCell.RowIndex >= 0)
            {
                // Set currentcell to AppointmentListCounter value
                grd_AppointmentList.CurrentCell = grd_AppointmentList[0, AppointmentListCounter]; 
                // Deselect current row
                grd_AppointmentList.CurrentRow.Selected = false; 
                // If AppointmentListCounter less than total row count - 1
                if (AppointmentListCounter < grd_AppointmentList.RowCount - 1)
                {
                    //Increment AppointmentListCounter
                    AppointmentListCounter++;
                }
                // Set currentcell to AppointmentListCounter values
                grd_AppointmentList.CurrentCell = grd_AppointmentList[0, AppointmentListCounter];
                //Select the current row
                grd_AppointmentList.CurrentRow.Selected = true;
                //Get selected patient based on PatientID column
                //m_selectedPatient = ml.GetPatientByID(Convert.ToInt16(grd_AppointmentList.CurrentRow.Cells[0].Value));
                //Console.WriteLine(m_selectedPatient.Forename);
            }
        }
         /// <summary>
         /// Get Previous Patient upon click of button
         /// </summary>
         /// <param name="sender">MedicalStaffForm</param>
         /// <param name="e"></param>
        private void btn_previousPatient_Click(object sender, EventArgs e)
        {
            // If current cell index less than total row count and current cell index greater than 0
            if (grd_AppointmentList.CurrentCell.RowIndex <= grd_AppointmentList.RowCount && grd_AppointmentList.CurrentCell.RowIndex > 0)
            {
                // Decrement AppointmentListCounter
                AppointmentListCounter--;
                // Deselect the current row
                grd_AppointmentList.CurrentRow.Selected = false;
                // Set currentcell to AppointmentListCounter value
                grd_AppointmentList.CurrentCell = grd_AppointmentList[0, AppointmentListCounter];
                // Select current row
                grd_AppointmentList.CurrentRow.Selected = true;
            }

        }
    }
}
