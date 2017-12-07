/* Created by: R
 * First Created: 01/12/17
 * Last Edit: 01/12/17 16:22
 * Last Edit by: R
 */
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;

namespace UnitTests
{
    [TestClass]
    public class Ryan
    {
        Rota rota = new Rota();
        List<Rota> rotaList = new List<Rota>();
        RotaController rotCon = RotaController.Instance(); 
        Appointment app = new Appointment();
        List<Appointment> appList = new List<Appointment>();
        AppointmentController appCon = AppointmentController.Instance();
        Manager man = new Manager();
        MedicalStaff medStaff = new MedicalStaff();
        MetaLayer ml = MetaLayer.Instance();


        /// <summary>
        /// Tests for rota
        /// </summary>
        [TestMethod]
        public void RotaTest()
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
            Assert.AreEqual(1, rota.RotaEntryID);
            Assert.AreEqual("Linus", rota.Forename);
            Assert.AreEqual("Torvild", rota.Surname);
            Assert.AreEqual(03-03-03, rota.StartTime);
            Assert.AreEqual(03-33-33, rota.EndTime);
            Assert.AreEqual("Monday", rota.Days);
            Assert.AreEqual(1, rota.StaffID);
        }

        /// <summary>
        /// Tests for rota controller
        /// </summary>
        [TestMethod]
        public void RotaControllerTest()
        {
            
        }

        /// <summary>
        /// Tests for appointment
        /// </summary>
        [TestMethod]
        public void AppointmentTest()
        {
            app = new Appointment();
            app.MedicalStaffID = 1;
            app.PatientID = 1;
            app.AppAttend = true;
            app.AppointmentID = 1;
            //app.AppDate = 19980303;
            //app.AppTime = 03-03-03;
            app.Notes = "Notes";

            Assert.AreEqual(1, app.MedicalStaffID);
            Assert.AreEqual(1, app.PatientID);
            Assert.AreEqual(true, app.AppAttend);
            Assert.AreEqual(1, app.AppointmentID);
            //Assert.AreEqual(19980303, app.AppDate);
            //Assert.AreEqual(03-03-03, app.AppTime);
            Assert.AreEqual("Notes", app.Notes);
        }

        /// <summary>
        /// Tests for appointment controller
        /// </summary>
        [TestMethod]
        public void AppointmentControllerTest()
        {
            //appCon = new AppointmentController();
            //Assert.AreEqual();
        }

        /// <summary>
        /// Tests for manager
        /// </summary>
        [TestMethod]
        public void ManagerTest()
        {
            
        }

        /// <summary>
        /// Tests for the sections of the metalayer that i implemened
        /// </summary>
        [TestMethod]
        public void MetalayerSectionsTests()
        {
            // Tests for GetAppointmentById method
            app = new Appointment();
            app = ml.GetAppointmentById(1);
            Assert.AreEqual(1, app.MedicalStaffID);
            Assert.AreEqual(1, app.PatientID);

            // Tests for UpdateAppointment method
            app.MedicalStaffID = 2;
            ml.UpdateAppointment(app);

            // Tests for AddAppointment method
            app.AppDate = new DateTime(2017, 11, 12);
            app.AppTime = new DateTime(2017, 11, 12,16,15,00);
            app.Notes = "Follow up";
            app.AppAttend = true;
            app.MedicalStaffID = 1;
            app.PatientID = 1;
            ml.AddAppointment(app);

            // Tests for GetStaffRotaByID method
            rota = new Rota();
            rota.RotaEntryID = 1;
            ml.GetStaffRotaByID(rota);

            // Tests the AddRota method
            rota.StaffID = 1;
            rota.StartTime = 161500;
            rota.Forename = "Linus";
            rota.Surname = "Torvild";
            rota.EndTime = 163500;
            rota.Days = "Monday";
            ml.AddRota(rota);

            // Tests for UpdateRota method
            rota.EndTime = 164504;
            ml.UpdateRota(rota);

            // Tests for GetMissedAppointments method
            appList = new List<Appointment>();
            appList = ml.GetMissedAppointments();

            // Tests for AddMedicalStaff method
            medStaff.Type = 1;
            medStaff.Forename = "Test";
            medStaff.Surname = "Testing";
            medStaff.Username = "tester";
            medStaff.PrescriptionLevel = 1;
            medStaff.Password = "password123";
            medStaff.PhoneNumber = "123456789";
            medStaff.Gender = 0;
            medStaff.EmailAddress = "test@test.com";
            ml.AddMedicalStaff(medStaff);
        }
    }
}
