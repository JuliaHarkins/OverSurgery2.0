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
        public List<Patient> patients;
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

        public void AddNewPatient(Dictionary<string,object> p_PatientValues)
        {
            patients.Add(PersonFactory.Instance().CreatePatient(p_PatientValues));
            MetaLayer.Instance().InsertNewPatient(null); //Sort this later;
        }

        public void UpdatePatientDoctorDisplay()
        {
            foreach(Patient p in patients)
            {
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