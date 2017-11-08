using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public abstract class Person
    {
        private string m_firstName;
        private string m_lastName;
        private string m_email;

        public string FirstName { get { return m_firstName; } set { m_firstName = value; } }
        public string LastName { get { return m_lastName; } set { m_lastName = value; } }
        public string EmailAddress { get { return m_email; } set { m_email = value; } }
    }
    

}
