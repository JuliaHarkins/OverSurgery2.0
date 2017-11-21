/* Created by: L
 * First Created: 31/10/17
 * Last Edit: 14/11/17 16:22
 * Last Edit by: R
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace OverSurgery2
{
    /// <summary>
    ///                              
    /// </summary>
    public abstract class Person : IDisposable
    {
        private string m_forename;
        private string m_surname;
        private string m_phoneNumber;
        private uint? m_gender;
        private uint? m_addressID;
        private string m_genderDisplay;
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string PhoneNumber { get { return m_phoneNumber; } set { m_phoneNumber = value; } }
        public uint? Gender { get { return m_gender; } set { m_gender = value; } }
        public string Forename { get { return m_forename; } set { m_forename = value; } }
        public string Surname { get { return m_surname; } set { m_surname = value; } }
        public uint? AddressID { get { return m_addressID; } set { m_addressID = value; } }
        public string GenderDisplay { get { return m_genderDisplay; }}

        public Person()
        {
            if(m_gender == 1)
            {
                m_genderDisplay = "Male";
            }
            else
            {
                m_genderDisplay = "Female";
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                handle.Dispose();
            }
            disposed = true;
        }
    }
    

}
