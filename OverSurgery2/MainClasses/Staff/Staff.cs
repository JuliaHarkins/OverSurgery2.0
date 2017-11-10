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
    public abstract class Staff : Person
    {
        private int m_staffID;
        private string m_username;
        private string m_password;
        public string Password { get { return m_password; } }
        LoginController lc = LoginController.Instance();

        public Staff(Dictionary<string, object> p_PersonValues) :base(p_PersonValues)
             {
            
            m_staffID = Convert.ToInt16(p_PersonValues["ID"]);
            m_username = Convert.ToString(p_PersonValues["UserName"]);
            m_password = Convert.ToString(p_PersonValues["Password"]);
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
