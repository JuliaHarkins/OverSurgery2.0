using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public abstract class Person
    {
        private string m_Forename;
        private string m_Surname;
        private string m_email;

        public string Forename { get { return m_Forename; } set { m_Forename = value; } }
        public string Surname { get { return m_Surname; } set { m_Surname = value; } }
        public string EmailAddress { get { return m_email; } set { m_email = value; } }
    }
    

}
