/* Created by: J
 * Date Created : 31/10/17
 * Last Edit: 07/11/17 16:22
 * Last Edit by: R
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery.Class_Diagram_Classes
{
    /// <summary>
    /// Handles interaction with appointment
    /// </summary>
    class AppointmentController
    {
        Appointment a;
#region Properties
        List<Appointment> AppointmentList = new List<Appointment>();                                                                // List of properties to be sent and recieved
        protected string Notes;
        protected int MedicalStaffID;
        protected int PatientID;
        protected string PatientForename;
        protected string PatientSurname;
        protected int PatientDOB;
        protected int AppDate;
        protected int AppTime;
        MetaLayer instance = MetaLayer.Instance();
        #endregion
        /// <summary>
        /// Gives appointment details to the Appointment class to be stored
        /// </summary>
        /// <param name="AppDate"></param>
        /// <param name="AppTime"></param>
        /// <param name="MedicalStaffID"></param>
        /// <param name="PatientID"></param>
        /// <param name="PatientForename"></param>
        /// <param name="PatientSurname"></param>
        /// <param name="Notes"></param>
        /// <param name="PatientDOB"></param>
        public void UpdateAppointment(int AppDate ,int AppTime, int MedicalStaffID, int PatientID, string PatientForename, string PatientSurname, string Notes, int PatientDOB)
        {
            AppointmentList.Add(new Appointment(AppDate, AppTime, MedicalStaffID, PatientID, PatientForename, PatientSurname, Notes, PatientDOB));            
        }

        /// <summary>
        /// Search for a specific appointment for a patient
        /// </summary>
        //public void SearchAppointment()
        //{

        //    //Test the data the user has typed in to see if the appointment details entered are correct.
        //    try
        //    {
        //        if ((txtForename.Text == a.PatientForename) && (txtSurname.Text == a.PatientSurname) && (txtDOB.Text == a.PatientDOB))
        //        {


        //        }
        //        else if ((txtForename.Text == a.PatientForename) && (txtSurname.Text == a.PatientSurname))
        //        {

        //        }
        //        else if ((txtSurname.Text == a.PatientSurname) && (txtDOB.Text == a.PatientDOB))
        //        {

        //        }
        //    }
        //    catch
        //    {
        //        txtForename.Clear();
        //        txtForename.Text = "Appointment not found";
        //        txtSurname.Clear();
        //        txtDOB.Clear();
        //    }
        //}

        public void t()
        {
            a = new Appointment(20170101,03033000, 12, 12, "12", "12", "12", 20121212);
            string testNotes = a.Notes;
        }
    }
}
