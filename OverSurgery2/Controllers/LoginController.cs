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
        MetaLayer ml;
        PatientController pc;
        FormController fc;
        PersonFactory pf;
        Staff userLoggedIn;
        private static Random random = new Random();
        private int? m_type;
        private static LoginController m_getInstance;
        SmtpClient Client;
        private LoginController()
        {
            Client = new SmtpClient();
            Client.Host = "smtp.googlemail.com";
            Client.Port = 587;
            Client.UseDefaultCredentials = false;
            Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential("oversurgeryresetpass@gmail.com", "oversurgery1");
            ml = MetaLayer.Instance();
            pc = PatientController.Instance();
            fc = FormController.Instance();
            pf = PersonFactory.Instance();

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
            m_login = ml.GetLogin(p_username);

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
        public string GenerateVerification(int p_length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, p_length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        /// <summary>
        /// Send a password reset email to a user
        /// </summary>
        /// <param name="p_EmailAddress">Email address of the user</param>
        /// <param name="p_VerificationCode">Verification code used to identify user</param>
        /// <example>
        /// This example shows you how to use the <see cref=SendPasswordResetEmail/> method
        ///<c>SendPasswordResetEmail(user@example.com, 8I7Y534E); </>
        /// </example>
        public void SendPasswordResetEmail(string p_EmailAddress, string p_VerificationCode)
        {
            var mail = new MailMessage("oversurgeryresetpass@gmail.com", p_EmailAddress);
            mail.Subject = "Password Reset Request";
            mail.Body = "Someone has requested to reset the password for this account\nVerification Code: " 
                + p_VerificationCode + "\nDon't worry if you didn't make this request";
            Client.Send(mail);
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