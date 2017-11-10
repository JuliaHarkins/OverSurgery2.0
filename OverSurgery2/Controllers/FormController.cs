using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
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
        public void OpenMainForm()
        {
            Dictionary<Type, int> StaffTypes = new Dictionary<Type, int>
            {
                {typeof(MedicalStaff),1 },
                {typeof(Locum),2},
                {typeof(Doctor), 3},
                {typeof(Receptionist),4},
                {typeof(Manager), 5 }
            };

            switch(StaffTypes[currentUser.GetType()])
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
                case 5:
                    new ManagerForm(currentUser);
                    break;
            }
        }

        public void SetCurrentUser(string p_username)
        {
           currentUser = ml.GetStaffByUserName(p_username);
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
