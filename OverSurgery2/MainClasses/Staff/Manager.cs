/* Created by: J
 * First Created: 31/10/17
 * Last Edit: 14/11/17 16:22
 * Last Edit by: R
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class Manager : Staff
    {
        MetaLayer ml;

        public Manager()
        {

        }

        /// <summary>
        /// Add a staff member to the database from values in the 'Staff' class
        /// </summary>
        public void AddStaff(Staff staff)
        {
            ml.AddStaff(staff);
        }

        /// <summary>
        /// View all of the missed appointments in the database
        /// </summary>
        public void ViewMissedAppointments()
        {
            ml.GetMissedAppointments();
        }

        /// <summary>
        /// View the percentage of missed appointments compared against all appointments
        /// </summary>
        public void ViewPercentageMissed()
        {
            ml.GetMissedAppointments();
            ml.GetAppointments();
            
        }

        /// <summary>
        /// View all user logs
        /// </summary>
        public void ViewUserLogs()
        {

        }

        /// <summary>
        /// Update the staff rota with new data from the 'Rota' class
        /// </summary>
        public void UpdateRota(Rota rota)
        {
            ml.UpdateRota(rota);
        }

        /// <summary>
        /// Book a locum
        /// </summary>
        public void BookLocum()
        {

        }
    }
}
