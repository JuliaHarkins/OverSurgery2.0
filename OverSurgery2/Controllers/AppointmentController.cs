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

namespace OverSurgery2.Class_Diagram_Classes
{
    /// <summary>
    /// Handles interaction with appointment
    /// </summary>
    class AppointmentController
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
        /// <param name="AppointmentID"></param>
        /// <param name="AppAttend"></param>
        /// 
        public void UpdateAppointment()
        {
                    
        }

        public void AddNewAppointment()
        {

        }

        //public void test()
        //{
        //    a = new Appointment(20170101,03033000, 12, 12, "12", "12", "12", 20121212, 4326645);
        //    string testNotes = a.Notes;
        //}
    }
}
