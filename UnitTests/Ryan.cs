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
        //RotaController rotCon = new RotaController(); 
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
            // Create data for objects
            rota = new Rota();
            rota.RotaEntryID = 1;
            rota.Forename = "Linus";
            rota.Surname = "Torvild";
            rota.StartTime = 03-03-03;
            rota.EndTime = 03-33-33;
            rota.Days = "Monday";
            rota.StaffID = 1;

            // Testing the object variables are grabable
            Assert.AreEqual(1, rota.RotaEntryID, "Object not grabbed correctly");
            Assert.AreEqual("Linus", rota.Forename, "Object not grabbed correctly");
            Assert.AreEqual("Torvild", rota.Surname, "Object not grabbed correctly");
            Assert.AreEqual(03-03-03, rota.StartTime, "Object not grabbed correctly");
            Assert.AreEqual(03-33-33, rota.EndTime, "Object not grabbed correctly");
            Assert.AreEqual("Monday", rota.Days, "Object not grabbed correctly");
            Assert.AreEqual(1, rota.StaffID, "Object not grabbed correctly");
        }

        /// <summary>
        /// Tests for rota controller
        /// </summary>
        [TestMethod]
        public void RotaController()
        {
            //rotCon = new RotaController();
            //Assert.AreEqual("Linus", rota.Forename, "Object not grabbed correctly");
        }

        /// <summary>
        /// Tests for appointment
        /// </summary>
        [TestMethod]
        public void Appointment()
        {
            app = new Appointment();
            app.MedicalStaffID = 1;
            app.PatientID = 1;
            app.AppAttend = true;
            app.AppointmentID = 1;
            //app.AppDate = 19980303;
            //app.AppTime = 03-03-03;
            app.Notes = "Notes";

            Assert.AreEqual(1, app.MedicalStaffID, "Object not grabbed correctly");
            Assert.AreEqual(1, app.PatientID, "Object not grabbed correctly");
            Assert.AreEqual(true, app.AppAttend, "Object not grabbed correctly");
            Assert.AreEqual(1, app.AppointmentID, "Object not grabbed correctly");
            //Assert.AreEqual(19980303, app.AppDate, "Object not grabbed correctly");
            //Assert.AreEqual(03-03-03, app.AppTime, "Object not grabbed correctly");
            Assert.AreEqual("Notes", app.Notes, "Object not grabbed correctly");
        }

        /// <summary>
        /// Tests for appointment controller
        /// </summary>
        [TestMethod]
        public void AppointmentController()
        {
            //appCon = new AppointmentController();
            //Assert.AreEqual();
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
