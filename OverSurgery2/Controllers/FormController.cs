using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class FormController
    {
        private static FormController m_getInstance;
        private FormController()
        {

        }
        public static FormController Instance()
        {
            if (m_getInstance == null)
            {
                m_getInstance = new FormController();
            }
            return m_getInstance;
        }

        public void OpenMainForm(int? type, string currentUser)
        {
            switch (type)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    new ReceptionistForm(currentUser);
                    break;
            }
        }

        public void OpenPatientViewForm(int id)
        {
            new ViewPatientInfoForm(id);
        }

        public void OpenForgotPasswordForm()
        {
            new ForgotPasswordForm();
        }
        
        public void OpenPasswordResetForm(string p_user)
        {
            Console.WriteLine(p_user);
            new PasswordResetForm(p_user);
        }

        public void OpenEditPatientForm(int p_PatientID)
        {
            new EditPatientForm(p_PatientID);
        }
    }
}
