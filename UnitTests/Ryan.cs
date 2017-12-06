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
        RotaController rotCon = new RotaController();
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
        /// Tests for rota
        /// </summary>
        [TestMethod]
        public void Rota()
        {
            rota = new Rota(null, 1, "03-03-03", "03-33-33", "Linus", "Torvild", "Monday");
            Asserts.AreEqual("Linus", rota.Forename, "Object not grabbed correctly");
        }

        /// <summary>
        /// Tests for rota controller
        /// </summary>
        public void RotaController()
        {
            rota = new Rota(null, 1, "03-03-03", "03-33-33", "Linus", "Torvild", "Monday");
            Asserts.AreEqual("Linus", rota.Forename, "Object not grabbed correctly");
        }

        /// <summary>
        /// Tests for appointment
        /// </summary>
        [TestMethod]
        public void Appointment()
        {
            app = new Appointment(null, 0, "1998-03-03", "03-03-03", 1, 1, 1);
            Asserts.AreEqual();
        }

        /// <summary>
        /// Tests for appointment controller
        /// </summary>
        [TestMethod]
        public void AppointmentController()
        {
            app = new Appointment(null, 0, "1998-03-03", "03-03-03", 1, 1, 1);
            Asserts.AreEqual();
        }

        /// <summary>
        /// Tests for manager
        /// </summary>
        [TestMethod]
        public void Manager()
        {
            
        }

        /// <summary>
        /// Tests for manager form
        /// </summary>
        [TestMethod]
        public void ManagerForm()
        {
            
        }

        /// <summary>
        /// Tests for person
        /// </summary>
        [TestMethod]
        public void Person()
        {
            
        }

    }
}
