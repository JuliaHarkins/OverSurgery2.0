using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 20/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// Patient Class, main patient object in System.
    /// </summary>
    public class Patient : Person
    {
        private int m_ID;
        private string m_dateOfBirth;
        private int m_registeredDoctorID;

        public Patient(Dictionary<string, object> p_PersonValues) : base(p_PersonValues)
        {

        }

        public int ID { get { return m_ID; } set { m_ID = value; } }
        public string DateOfBirth
        {
            get
            {
                return m_dateOfBirth;
            }
            set
            {
                m_dateOfBirth = value;
            }
        }
        public int RegisteredDoctorID {get { return m_registeredDoctorID; } set { m_registeredDoctorID = value; } }
    }
}
