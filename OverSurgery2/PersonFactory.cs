using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    /// <summary>
    /// Created by: L
    /// Modified by:
    /// Date Created: 31/10/2017
    /// This creates different types of people within the system
    /// </summary>
    public class PersonFactory
    {
        private static PersonFactory m_instance;

        public static PersonFactory Instance()
        {
            if(null == m_instance)
            {
                m_instance = new PersonFactory();
            }
            return m_instance;
        }
        // Let method decide which type of object to create
        public Person CreatePerson(params object[] args) // Arg order: Type of person, other args
        {
            switch(args[0].ToString())
            {
                case "Patient":
                    CreatePatient(args);
                    break;
                case "MedicalStaff":
                    break;
                case "Doctor":
                    CreateDoctor(); // Temporarily nulled as not fully implemented
                    break;
                case "Receptionist":
                    CreateReceptionist();
                    break;
                default:
                    break;
            }
            return null; // Temporarily return null
        }

        // Return a new patient
        public Patient CreatePatient(object[] args)
        {
            return new Patient() { FirstName = Convert.ToString(args[1]), LastName = Convert.ToString(args[2]) };
        }

        //Return a new doctor
        public Doctor CreateDoctor(/*Args here eventually*/)
        {
            return null;
        }
        
        //// Return a new receptionist
        public Receptionist CreateReceptionist()
        {
            return null;
        }
    }
}
