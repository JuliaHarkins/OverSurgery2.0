/* Created by: L
 * First Created: 20/10/17
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
    /// Handles appointment data
    /// </summary>
    class Appointment
    {
#region Member Variables
        private string m_notes;
        private int m_medicalStaffID;
        private int m_patientID;
        private string m_patientForename;
        private string m_patientSurname;
        private int m_patientDOB;
        private int m_appDate;
        private int m_appTime;
        private int m_appointmentID;
        private bool m_appAttend;
#endregion

#region Properties
        public string Notes { get { return m_notes; } set { m_notes = value; } } //Appointment.Notes;  
        public int MedicalStaffID { get { return m_medicalStaffID; } set { m_medicalStaffID = value; } }
        public int PatientID { get { return m_patientID; } set { m_patientID = value; } }
        public string PatientForename { get { return m_patientForename; } set { m_patientForename = value; } }
        public string PatientSurname { get { return m_patientSurname; } set { m_patientSurname = value; } }
        public int PatientDOB { get { return m_patientDOB; } set { m_patientDOB = value; } }
        public int AppDate { get { return m_appDate; } set { m_appDate = value; } }
        public int AppTime { get { return m_appTime; } set { m_appTime = value; } }                                                                               // Stores the date and time of the appointment
        public int AppointmentID { get { return m_appTime; } set { m_appTime = value; } }
        public bool AppAttend { get { return m_appAttend; } set { m_appAttend = value; } }
        #endregion

        /// <summary>
        /// Gets the details of the appointment from the AppointmentControler and patient details from the database
        /// </summary>
        /// <param name="p_appDate"></param>
        /// <param name="p_appTime"></param>
        /// <param name="p_medicalStaffID"></param>
        /// <param name="p_patientID"></param>
        /// <param name="p_patientForename"></param>
        /// <param name="p_patientSurname"></param>
        /// <param name="p_notes"></param>
        /// <param name="p_patientDOB"></param>
        /// <param name="p_appointmentID"></param>
        /// <param name="p_appAttend"></param>
        public Appointment(Dictionary <string,object> p_AppValues, int p_appDate, int p_appTime, int p_patientID, string p_notes, bool p_appAttend)
        {
            /*
             * What needs to be done:
             * Remove everything but the dictionary from the objects that are passed to the constructor
             * Change the assignments of the variables to take the values from the dictionary
            */
            // AppointmentID 
            // AppointmentDate
            // AppointmentTime
            // AppointmentNote
            // AppointmentAttended
            // MedicalStaffID
            // PatientID

            AppointmentID = Convert.ToInt16(p_AppValues["ID"]);
            MedicalStaffID = Convert.ToInt16(p_AppValues["RegisteredDoctorID"]);
            PatientID = p_patientID;
            AppDate = p_appDate;
            AppTime = p_appTime;
            Notes = p_notes;
            PatientForename = Convert.ToString(p_AppValues["Forename"]);
            PatientSurname = Convert.ToString(p_AppValues["Surname"]);
            //PatientDOB = Convert.ToString(p_AppValues["DateOfBirth"]);
            AppAttend = p_appAttend;
        }


    }

}
