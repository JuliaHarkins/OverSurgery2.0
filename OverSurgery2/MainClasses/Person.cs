using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public abstract class Person
    {
        private string m_forename;
        private string m_surname;
        private string m_email;
        private string m_phoneNumber;
        private uint? m_gender;
        private uint? m_addressID;

        public string PhoneNumber { get { return m_phoneNumber; } set { m_phoneNumber = value; } }
        public uint? Gender { get { return m_gender; } set { m_gender = value; } }
        public string Forename { get { return m_forename; } set { m_forename = value; } }
        public string Surname { get { return m_surname; } set { m_surname = value; } }
        public string EmailAddress { get { return m_email; } set { m_email = value; } }
        public uint? AddressID { get { return m_addressID; } set { m_addressID = value; } }
        public Person(Dictionary<string, object> p_PersonValues)
        {
            m_forename = Convert.ToString(p_PersonValues["Forename"]);
            m_surname = Convert.ToString(p_PersonValues["Surname"]);
            m_email = Convert.ToString(p_PersonValues["Email"]);
            m_phoneNumber = Convert.ToString(p_PersonValues["PhoneNumber"]);
            m_gender = Convert.ToUInt16(p_PersonValues["Gender"]);
            m_addressID = Convert.ToUInt16(p_PersonValues["AddressID"]);
        }
    }
    

}
