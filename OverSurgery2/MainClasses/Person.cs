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
        
        private uint? m_addressID;
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string Forename { get { return m_forename; } set { m_forename = value; } }
        public string Surname { get { return m_surname; } set { m_surname = value; } }
        public uint? AddressID { get { return m_addressID; } set { m_addressID = value; } }

        public Person()
        {

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
