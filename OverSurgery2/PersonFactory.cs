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
        public Staff CreateStaff(params object[] p_args) // Arg order: Type of person, other args
        {
            switch(p_args[0])
            {
                case 1:
                    break;
                case 2:
                    CreateLocum(p_args); // Temporarily nulled as not fully implemented
                    break;
                case 3:
                    break;
                case 4:
                    CreateReceptionist(p_args);
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
        public Doctor CreateDoctor(object[] p_args)
        {
            try
            {
                Dictionary<string, object> values = new Dictionary<string, object>
                {
                    {"FirstName", Convert.ToString(p_args[2]) },
                    {"LastName", Convert.ToString(p_args[3]) },
                    {"ID", Convert.ToInt16(p_args[4]) },
                    {"Email", Convert.ToString(p_args[5]) },
                    { }

                };
                return new Doctor(values);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        //// Return a new receptionist
        public Receptionist CreateReceptionist(object[] p_args)
        {
            try
            {
                return new Receptionist(Convert.ToInt16(p_args[1]), Convert.ToString(p_args[2]), Convert.ToString(p_args[3]), Convert.ToString(p_args[4]), Convert.ToString(p_args[5]), Convert.ToString(p_args[6]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return null;
        }

        public Locum CreateLocum(object[] p_args)
        {
            return null;
        }
    }
}
