using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class PatientController
    {
        /// <summary>
        /// Created By: J
        /// Date Created : 31/10/17
        /// </summary>
        private static PatientController m_getInstance;
        private PatientController()
        {

        }
        public static PatientController Instance()
        {
            if (m_getInstance == null)
            {
                m_getInstance = new PatientController();
            }
            return m_getInstance;
        }

        public void AddNewPatient(Patient p_Patient)
        {

        }
    }
}