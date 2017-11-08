using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class FormController
    {
        MetaLayer ml = MetaLayer.Instance();
        Staff currentUser;
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
        Dictionary<Type, int> typeDict = new Dictionary<Type, int>
        {
            {typeof(int),0},
            {typeof(string),1},
            {typeof(Receptionist),4}
        };
        public void OpenMainForm(Staff currentUser)
        {

            switch(typeDict[currentUser.GetType()])
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    //new ReceptionistForm(currentLoggedIn);
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
