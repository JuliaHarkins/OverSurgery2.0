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

namespace OverSurgery2
{
    /// <summary>
    /// Handles interaction with appointment
    /// </summary>
    public class AppointmentController
    {
        Appointment a;

#region Properties
        List<Appointment> AppointmentList = new List<Appointment>();                                                                // List of properties to be sent and recieved
        private string Notes;
        private int MedicalStaffID;
        private int PatientID;
        private string PatientForename;
        private string PatientSurname;
        private int PatientDOB;
        private int AppDate;
        private int AppTime;
        private int AppointmentID;
        private bool AppAttend;
#endregion

        private static AppointmentController m_instance;
        public static AppointmentController Instance()
        {
            if(null == m_instance)
            {
                m_instance = new AppointmentController();
            }
            return m_instance;
        }

        /// <summary>
        /// Update an existing appointment with new data
        /// </summary>
        public void UpdateAppointment()
        {
           /* Collect data from receptionist
            * Send data to appointment
            * Collect existing data from that appointment from metalayer to appointment
            * Merge the data
            * Update Database
            */
        }

        /// <summary>
        /// Add a brand new appointment to the database
        /// </summary>
        public void AddNewAppointment()
        {
           /* Collect data from receptionist
            * Send data to appointment
            * Forward onto metalayer and update Database
            */
        }

        /// <summary>
        /// Find data about an existing appointment
        /// </summary>
        public void GetExistingAppointment()
        {
            /* Collect ID from receptionist
             * Send ID to appointment
             * Collect existing data from that appointment from metalayer to appointment
             * Send data from appointment to controller
             */

            //PatientID = Receptionist.p_patientID;

        }

        //public void test()
        //{
        //    a = new Appointment(20170101,03033000, 12, 12, "12", "12", "12", 20121212, 4326645);
        //    string testNotes = a.Notes;
        //}
    }
}
