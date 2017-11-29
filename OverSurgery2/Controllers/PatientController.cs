using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class PatientController : IObservable<Patient>
    {
        /// <summary>
        /// Created By: J
        /// Date Created : 31/10/17
        /// </summary>
        private List<IObserver<Patient>> observers;
        public IDisposable Subscribe(IObserver<Patient> observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
                foreach(Patient p in patients)
                {
                    observer.OnNext(p);
                }
                
            }
            return new Unsubscriber<Patient>(observers, observer);
        }
        public List<Patient> patients;
        private static PatientController m_getInstance;
        private PatientController()
        {
            patients = MetaLayer.Instance().GetPatients();
        }
        public static PatientController Instance()
        {
            if (m_getInstance == null)
            {
                m_getInstance = new PatientController();
            }
            return m_getInstance;
        }

        public void UpdatePatientList()
        {
            patients = MetaLayer.Instance().GetPatients();
            UpdatePatientDoctorDisplay();
        }

        public void AddNewPatient(Patient p_newPatient)
        {
            patients.Add(p_newPatient);
            MetaLayer.Instance().InsertNewPatient(p_newPatient);
        }

        public void UpdatePatientDoctorDisplay()
        {
            foreach(Patient p in patients)
            {
                p.SetGenderDisplay();
                p.SetDoctorDisplay();
            }
        }
    }

    internal class Unsubscriber<Patient> : IDisposable
    {
        private List<IObserver<Patient>> _observers;
        private IObserver<Patient> _observer;

        internal Unsubscriber(List<IObserver<Patient>> observers, IObserver<Patient> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}