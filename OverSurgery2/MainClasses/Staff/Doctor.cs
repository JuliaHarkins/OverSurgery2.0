using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class Doctor : MedicalStaff
    {
        public bool OnCall { get; set; }

        /// <summary>
        /// used to create a doctor
        /// 07/11/2017 - j
        /// </summary>
        public Doctor()
        {

        }
    }
}