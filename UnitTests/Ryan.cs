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
        Rota rotaTest = new Rota();
        List<Rota> rotaList = new List<Rota>();
        RotaController rotCon = RotaController.Instance(); 
        Appointment app = new Appointment();
        Appointment appTest = new Appointment();
        List<Appointment> appList = new List<Appointment>();
        AppointmentController appCon = AppointmentController.Instance();
        Manager man = new Manager();
        MedicalStaff medStaff = new MedicalStaff();
        MedicalStaff medStaffTest = new MedicalStaff();
        Staff staffTest = new Staff();
        MetaLayer ml = MetaLayer.Instance();
        Address add = new Address();

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
            app.AppDate = new DateTime(2017, 12, 12);
            app.AppTime = new DateTime(2017, 12, 12, 16, 15, 00);
            app.Notes = "Notes";

            Assert.AreEqual(1, app.MedicalStaffID);
            Assert.AreEqual(1, app.PatientID);
            Assert.AreEqual(true, app.AppAttend);
            Assert.AreEqual(1, app.AppointmentID);
            Assert.AreEqual(new DateTime(2017, 12, 12), app.AppDate);
            Assert.AreEqual(new DateTime(2017, 12, 12, 16, 15, 00), app.AppTime);
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
            appTest = ml.GetAppointmentById(1);
            Assert.AreEqual(1, appTest.MedicalStaffID);
            Assert.AreEqual(1, appTest.PatientID);

            // Tests for UpdateAppointment method
            app.MedicalStaffID = 2;
            ml.UpdateAppointment(app);
            appTest = ml.GetAppointmentById(1);
            Assert.AreEqual(2, appTest.MedicalStaffID);
            Assert.AreEqual(1, appTest.PatientID);

            // Tests for AddAppointment method
            app.AppDate = new DateTime(2017, 11, 12);
            app.AppTime = new DateTime(2017, 11, 12, 16, 15, 00);
            app.Notes = "Follow up";
            app.AppAttend = true;
            app.MedicalStaffID = 1;
            app.PatientID = 1;
            ml.AddAppointment(app);

            appList = ml.GetAppointments();
            appTest = appList[-1];                                                                                                          // Take the last list entry and store it in the test appointment
            Assert.AreEqual("Follow up", appTest.Notes);
            Assert.AreEqual(true, appTest.AppAttend);
            Assert.AreEqual(1, appTest.MedicalStaffID);
            Assert.AreEqual(1, appTest.PatientID);
            Assert.AreEqual(new DateTime(2017, 11, 12, 16, 15, 00), appTest.AppTime);
            Assert.AreEqual(new DateTime(2017, 11, 12), appTest.AppDate);

            // Tests for GetStaffRotaByID method
            rota = new Rota();
            rota.RotaEntryID = 1;
            rotaList = ml.GetStaffRotaByID(rota);

            // Tests the AddRota method
            rota.StaffID = 1;
            rota.StartTime = 161500;
            rota.Forename = "Linus";
            rota.Surname = "Torvild";
            rota.EndTime = 163500;
            rota.Days = "Monday";
            ml.AddRota(rota);

            rotaList = ml.GetStaffRota();
            rotaTest = rotaList[-1];                                                                                                        // Take the last list entry and store it in the test rota
            Assert.AreEqual("Linus", rotaTest.Forename);
            Assert.AreEqual("Torvild", rotaTest.Surname);

            // Tests for UpdateRota method
            rota.RotaEntryID = 1;
            rota.EndTime = 164504;
            ml.UpdateRota(rota);
            rotaList = ml.GetStaffRotaByID(rota);

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

            staffTest = ml.GetStaffByUserName(medStaff.Username);
            Assert.AreEqual("Test", staffTest.Forename);
            Assert.AreEqual("Testing", staffTest.Surname);
            Assert.AreEqual("tester", staffTest.Username);
            Assert.AreEqual("test@test.com", staffTest.EmailAddress);
            Assert.AreEqual(1, staffTest.Type);

            // Tests for UpdateMedicalStaff method
            medStaff.Forename = "Tester";
            ml.UpdateMedicalStaff(medStaff);

            // Tests for DeleteStaff method

            // Tests for UpdateStaffMember method

            // Tests for DeleteAddress method

            // Tests for UpdateAddress method

            // Tests for AddAddress method

            // Tests for DeleteMedication method

            // Tests for GetMedicationByName method

            // Tests for AddMedication method

            // Tests for UpdateMedication method
        }
    }
}
