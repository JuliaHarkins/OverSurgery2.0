using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /*
     * The Doctor class Holds the list of extentions along with all of the
     * doctors information. The doctor class is inherited from MedicalStaff
     * 
     * LAstUpdated 
     * 
     * By: J
     */
    public class Doctor : MedicalStaff
    {
        #region Properties
        public bool OnCall { get; set; }

        #endregion
        /// <summary>
        /// used to create a doctor
        /// 07/11/2017 - j
        /// </summary>
        public Doctor()
        {
        }

    }
}