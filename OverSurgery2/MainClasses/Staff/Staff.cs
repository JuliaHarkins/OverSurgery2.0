using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// Created by: L
    /// First Created: 20/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: L
    public class Staff : Person
    {
        private int m_staffID;
        private string m_username;
        private string m_password;
        private string m_email;

        public string Password { get { return m_password; } set { m_password = value; } }
        public string Username { get { return m_username; } set { m_username = value; } }
        public string EmailAddress { get { return m_email; } set { m_email = value; } }
        public int StaffID { get { return m_staffID; } set { m_staffID = value; } }
        LoginController lc = LoginController.Instance();

        public Staff()
        {

        }
        //public bool Login(string p_username, string p_attemptedPassword)
        //{
        //    bool loginValidated;
        //    if (lc.ValidateLogin())
        //    {
        //        loginValidated = true;
        //    }
        //    else
        //    {
        //        loginValidated = false;
        //    }
        //    return loginValidated;
    }
    }
