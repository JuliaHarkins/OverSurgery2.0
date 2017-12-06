/* Created by: R
 * First Created: 01/12/17
 * Last Edit: 01/12/17 16:22
 * Last Edit by: R
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;

namespace UnitTests
{
    [TestClass]
    public class Ryan
    {
        Rota rota = new Rota();
        Appointment app = new Appointment();
        //AppointmentController appCon = new AppointmentController();
        Manager man = new Manager();
        //ManagerForm manForm = new ManagerForm();
        //Person per = new Person();
        MetaLayer ml = MetaLayer.Instance();

        [TestMethod]
        public void TestMethod1()
        {
        }
        
        /// <summary>
        /// Tests for rota form
        /// </summary>
        [TestMethod]
        public void Rota()
        {
            rota = new Rota(null, 1, "03-03-03", "03-33-33", "Mr", "Rota", "Monday");
        }

        /// <summary>
        /// Tests for appointment form
        /// </summary>
        [TestMethod]
        public void Appointment()
        {
            app = new Appointment(null, 0, "1998-03-03", "03-03-03", 1, 1, 1);
        }

        /// <summary>
        /// Tests for appointment controller form
        /// </summary>
        [TestMethod]
        public void AppointmentController()
        {
            
        }

        /// <summary>
        /// Tests for manager form
        /// </summary>
        [TestMethod]
        public void Manager()
        {
            
        }

        /// <summary>
        /// Tests for manager form form
        /// </summary>
        [TestMethod]
        public void ManagerForm()
        {
            
        }

        /// <summary>
        /// Tests for person form
        /// </summary>
        [TestMethod]
        public void Person()
        {
            
        }

    }
}
