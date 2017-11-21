using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /*
     * The Doctor class Holds the list of extentions along with all of the
     * doctors information. The doctor class is inherited from MedicalStaff
     * 
     * LAstUpdated 
     * 
     * By: J
     */
    public class Doctor : MedicalStaff
    {
        #region Member Variables 
        bool m_onCall;
        List<Prescription> m_extension;
        MetaLayer ml;

        #endregion
        #region Properties
        public bool OnCall
        {
            get
            {
                return m_onCall;
            }
            set
            {
                m_onCall = value;
            }
        }
        public List<Prescription> Extension
        {
            get
            {
                return m_extension;
            }
            set
            {
                m_extension = value;
            }

        }
        #endregion
        /// <summary>
        /// used to create a doctor
        /// 07/11/2017 - j
        /// </summary>
        #region Constructor
        public Doctor()
             {
             }
        
        #endregion

        #region Methoods
        /// <summary>
        /// takes the Prescription, returns a bool, then removes it from the doctors extention requests
        /// 01/11/2017 - j
        /// </summary>
        /// <param name="p_prescription">the Prescription object that is to be extended</param>
        /// <returns></returns>
        private bool ExtendMedication(Prescription p_prescription)
        {
            RemoveExtention(p_prescription);
            return true;

        }
        /// <summary>
        /// Removes the Prescription from the extend list without updating it.
        /// 07/11/2017 - j
        /// </summary>
        /// <param name="p_prescription">the Prescription object that isn't to be extented</param>
        private void RemoveExtention(Prescription p_prescription)
        {
            m_extension.Remove(p_prescription);
        }
        public void addExtention(Prescription p_p)
        {
            m_extension.Add(p_p);
        }
        #endregion
    }
}
