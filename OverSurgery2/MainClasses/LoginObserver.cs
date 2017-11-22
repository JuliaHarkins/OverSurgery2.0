using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    class LoginObserver
    {
#region Member Variables
        private string m_username;
        private string m_password;
        Dictionary<string, string> m_loginPassThrough;
        LoginController lc = LoginController.Instance();
#endregion
#region Construcors
#endregion
#region Properties
        public string Username
        {
            get
            {
                return m_username;
            }
            set
            {
                m_username = value;
            }
        }
        public string Password
        {
            get
            {
                return m_password;
            }
            set
            {
                m_password = value;
            }
        }
#endregion


        public Dictionary<string, string> LoginPassThrough(string m_username, string m_password)
        {
#region Declaration
#endregion
#region Initialisation
            m_loginPassThrough = new Dictionary<string, string>();
#endregion
#region Execution
            m_password = lc.HashPassword(m_password);
            m_loginPassThrough.Add("Username", m_username);
            m_loginPassThrough.Add("Password", m_password);
            lc.ValidateLogin(m_loginPassThrough);
#endregion
#region Return
            return m_loginPassThrough;
#endregion
        }
    }
}
