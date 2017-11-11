using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
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
        public enum Gender { Male, Female };
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
        /// <c></c>
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
                    return CreateLocum(values);
                case 3:
                    return CreateDoctor(values);
                case 4:
                    return CreateReceptionist(values);
                case 5:
                    return CreateManager(values);
                default:
                    break;
            }
            return null; // Temporarily return null
        }

        // Return a new patient
        public Patient CreatePatient(Dictionary<string,object> p_values)
        {
            if (p_values == null)
            {
                throw new ArgumentNullException(nameof(p_values));
            }
            try
            {
                return new Patient(p_values);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }



        //Return a new doctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_args">Forename, Surname,ID,Email,UserName,Password,PhoneNumber,Gender</param>
        /// <returns></returns>
        private Doctor CreateDoctor(Dictionary<string, object> p_values)
        {
            if (p_values == null)
            {
                throw new ArgumentNullException(nameof(p_values));
            }

            try
            {
                return new Doctor(p_values);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        //// Return a new receptionist
        public Receptionist CreateReceptionist(Dictionary<string,object> p_values)
        {
            if (p_values == null)
            {
                throw new ArgumentNullException(nameof(p_values));
            }

            try
            {
               return new Receptionist(p_values);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public Locum CreateLocum(Dictionary<string, object> p_values)
        {
            if (p_values == null)
            {
                throw new ArgumentNullException(nameof(p_values));
            }
            try
            {
                return new Locum(p_values);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public Manager CreateManager(Dictionary<string,object> p_values)
        {
            if (p_values == null)
            {
                throw new ArgumentNullException(nameof(p_values));
            }
            try
            {
                return new Manager(p_values);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
