using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace OverSurgery2
{
    /// <summary>
    /// Created by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// First Created: 20/10/17
    /// Last Edit: 21/10/17 14:22
    /// Last Edit by: Lewis Barnes (362490@edu.cwa.ac.uk)
    /// </summary>
    public class LoginController
    {
        Staff userLoggedIn;
        MetaLayer ml = MetaLayer.Instance();
        private static Random random = new Random();
        private int? m_type;
        private static LoginController m_getInstance;
        SmtpClient client;
        private LoginController()
        {
            client = new SmtpClient();
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("oversurgeryresetpass@gmail.com", "oversurgery1");

        }
        public int? Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        public static LoginController Instance()
        {
            if(m_getInstance == null)
            {
                m_getInstance = new LoginController();
            }
            return m_getInstance;
        }
        public bool ValidateLogin(Dictionary<string, string> p_loginPassThrough)
        {
#region Declaration
            bool m_flg;
            string p_username;
            string p_password;
            Tuple<string, string, int?> m_login;
#endregion
#region Initialisation
            m_flg = false;
            p_username = p_loginPassThrough["Username"];
            p_password = p_loginPassThrough["Password"];
            m_login = new Tuple<string, string, int?>(null, null, null);
#endregion
#region Execution
            m_login = MetaLayer.Instance().GetLogin(p_username);

            if (p_username == m_login.Item1)
            {
                if (p_password == m_login.Item2)
                {
                    m_flg = true;
                    Type = m_login.Item3;
                }
            }
            else
            {
                m_flg = false;
            }
#endregion
#region Return
            return m_flg;
#endregion
        }
        public string GenerateVerification(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void SendPasswordResetEmail(string EmailAddress, string VerificationCode)
        {
            MailMessage mail = new MailMessage("oversurgeryresetpass@gmail.com", EmailAddress);
            mail.Subject = "Password Reset Request";
            mail.Body = "Someone has requested to reset the password for this account\nVerification Code: " + VerificationCode + "\nDon't worry if you didn't make this request";
            client.Send(mail);
        }

        public bool VerifyPasswordReset(Staff p_user, string p_verificationCode)
        {
            
            if(ml.GetResetRequestCode(p_user) != p_verificationCode)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string HashPassword(string p_password)
        {
            int passwordCost = 13;
            string passwordSalt = "/8Wncr26eAmxD1l6cAF9F8";
            string salt = "$2a$" + passwordCost + "$" + passwordSalt;
            p_password = BCrypt.Net.BCrypt.HashPassword(p_password, salt);
            return p_password;
        }

        public Staff GetLoggedInUser(string p_username)
        {
            Staff s = ml.GetStaffByUserName(p_username);
            return s;
        }
    }
}