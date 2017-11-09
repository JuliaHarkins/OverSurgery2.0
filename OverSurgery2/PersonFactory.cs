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
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// This example shows you how to use the <see cref="CreateStaff(object[])"/> method.
        /// <c>Staff st = pf.CreateStaff(3, "Lewis", "Barnes", null, "test@email.com", "LewisB", "7a8l48u2g/5ur837", "07658885433", 0);</c>
        /// </example>
        /// <param name="values">Type(1-5),Forename,Surname,ID,Email,UserName,Password,PhoneNumber,Gender</param>
        /// <returns></returns>
        public Staff CreateStaff(Dictionary<string, object> values) // Arg order: Type of person, other args
        {
            switch(Convert.ToInt16(values["Type"]))
            {
                case 1:
                    break;
                case 2:
                    CreateLocum(values); // Temporarily nulled as not fully implemented
                    break;
                case 3:
                    return CreateDoctor(values);
                case 4:
                    //return CreateReceptionist(values);
                    break;
                default:
                    break;
            }
            return null; // Temporarily return null
        }

        // Return a new patient
        public Patient CreatePatient(object[] args)
        {
            return new Patient() { Forename = Convert.ToString(args[1]), Surname = Convert.ToString(args[2]) };
        }

        //Return a new doctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_args">Forename, Surname,ID,Email,UserName,Password,PhoneNumber,Gender</param>
        /// <returns></returns>
        private Doctor CreateDoctor(Dictionary<string, object> values)
        {
            try
            {
                return new Doctor(values);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        //// Return a new receptionist
        public Receptionist CreateReceptionist(Dictionary<string,object> values)
        {
            try
            {
               /// return new Receptionist(values);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return null;
        }

        public Locum CreateLocum(Dictionary<string, object> values)
        {
            return null;
        }
    }
}
