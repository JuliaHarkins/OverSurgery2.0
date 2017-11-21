using System;
using System.Collections.Generic;

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
        MetaLayer ml;
        public enum Gender { Male, Female };
        private PersonFactory()
        {
            ml = MetaLayer.Instance();
        }
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
        /// <c>CreateStaff</c>
        /// </example>
        /// <param name="values">Type(1-5),Forename,Surname,ID,Email,UserName,Password,PhoneNumber,Gender</param>
        /// <returns></returns>
        public Staff CreateStaff(Dictionary<string, object> values) // Arg order: Type of person, other args
        {
            switch(Convert.ToInt16(values["Type"]))
            {
                case 1:
                    return CreateMedicalStaff(values);
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
                return new Patient();
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
        /// <param name="p_values">Forename, Surname,ID,Email,UserName,Password,PhoneNumber,Gender</param>
        /// <returns></returns>
        public Doctor CreateDoctor(Dictionary<string, object> p_values)
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
               return new Receptionist();
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
                return new Locum();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public MedicalStaff CreateMedicalStaff(Dictionary<string, object> p_values)
        {
            if (p_values == null)
            {
                throw new ArgumentNullException(nameof(p_values));
            }
            try
            {
                return new MedicalStaff();
            }
            catch (Exception e)
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
                return new Manager();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}