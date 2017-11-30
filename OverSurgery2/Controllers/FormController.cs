using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverSurgery2.UserInterface;

namespace OverSurgery2
{
    public class FormController
    {
        Staff m_currentUser;
        private static FormController m_getInstance;
        private readonly MetaLayer m_ml;
        private FormController()
        {
            m_ml = MetaLayer.Instance();
        }
        /// <summary>
        /// Return an instance of FormController.
        /// </summary>
        /// <returns></returns>
        public static FormController Instance()
        {
            return m_getInstance ?? (m_getInstance = new FormController());
        }
        /// <summary>
        /// Open the main form for the user logged in.
        /// </summary>
        public void OpenMainForm()
        {
            // Open correct form for each user, switch on user type.
            switch (m_currentUser.Type)
            {
                case 1:
                case 2:
                case 3:
                    new MedicalStaffForm(m_currentUser).ShowDialog();
                    break;
                case 4:
                    new ReceptionistForm(m_currentUser).ShowDialog();
                    break;
                case 5:
                    new ManagerForm(m_currentUser).ShowDialog();
                    break;
            }
        }
        /// <summary>
        /// Set the current user logged in using a username that is passed to the method.
        /// </summary>
        /// <param name="p_username"></param>
        public void SetCurrentUser(string p_username)
        {
            // Get the current user from the database using their username.
            m_currentUser = m_ml.GetStaffByUserName(p_username);
        }

        public void OpenPatientViewForm(Patient p_patient)
        {
            new ViewPatientInfoForm(p_patient).ShowDialog();
        }
        /// <summary>
        /// Open the forgot password form for the user to get a verification code to reset their password.
        /// </summary>
        public void OpenForgotPasswordForm()
        {
            // Create new ForgotPasswordForm instance and ShowDialog.
            new ForgotPasswordForm().ShowDialog();
        }
        /// <summary>
        /// Open the password reset form for the user to reset their password.
        /// </summary>
        /// <param name="p_user"></param>
        public void OpenPasswordResetForm(Staff p_user)
        {
            // Open a new instance of PasswordResetForm, pass the current use to it and ShowDialog.
            new PasswordResetForm(p_user).ShowDialog();
        }

        public void OpenEditPatientForm(Patient p_patient)
        {
            // Open a new instance of EditPatientForm, pass the patient to it and ShowDialog.
            new NewPatientForm(p_patient).ShowDialog();
        }

        public void OpenNewPatientForm()
        {
            // Open a new instance of NewPatientForm
            new NewPatientForm().ShowDialog();
        }
        public void UpdateData()
        {
           
        }
        public void OpenNewAppointmentForm()
        {
            new NewAppointmentForm().ShowDialog();
        }
    }
}
