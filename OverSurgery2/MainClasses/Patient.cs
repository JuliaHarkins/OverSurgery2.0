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
        private int m_address;
        private string m_phoneNumber;

        public int ID { get { return m_ID; } set { m_ID = value; } }
        public int Address { get { return m_address; } set { m_address = value; } }
        public string PhoneNumber { get { return m_phoneNumber; } set { m_phoneNumber = value; } }
    }
}
