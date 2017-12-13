/* Created by: R
 * First Created: 01/12/17
 * Last Edit: 01/12/17 16:22
 * Last Edit by: R
 */
using System;
using System.Collections.Generic;
using System.Linq;
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
        Appointment app = new Appointment();
        Appointment appTest = new Appointment();
        List<Appointment> appList = new List<Appointment>();
        AppointmentController appCon = AppointmentController.Instance();
        Manager man = new Manager();
        MedicalStaff medStaff = new MedicalStaff();
        MedicalStaff medStaffTest = new MedicalStaff();
        Staff staff = new Staff();
        Staff staffTest = new Staff();
        Address add = new Address();
        Address addTest = new Address();
        Medication med = new Medication();
        Medication medTest = new Medication();
        List<Medication> medList = new List<Medication>();
        MetaLayer ml = MetaLayer.Instance();

        string column, passedData, DeleteStaffCatch = null, DeleteAddressCatch = null, DeleteMedicationCatch = null;

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
            
        }

        /// <summary>
        /// Tests for manager
        /// </summary>
        [TestMethod]
        public void ManagerTest()
        {
            //man.Manager();
        }

        /// <summary>
        /// Tests for GetAppointmentById method
        /// </summary>
        [TestMethod]
        public void MetalayerGetAppointmentById()
        {
            app = ml.GetAppointmentById(1);
            Assert.AreEqual(1, app.MedicalStaffID);
            Assert.AreEqual(1, app.PatientID);
        }

        /// <summary>
        /// Tests for UpdateAppointment method
        /// </summary>
        [TestMethod]
        public void MetalayerUpdateAppointment()
        { 
            app = ml.GetAppointmentById(1);
            app.MedicalStaffID = 2;
            ml.UpdateAppointment(app);
            appTest = ml.GetAppointmentById(1);
            Assert.AreEqual(2, appTest.MedicalStaffID);
            Assert.AreEqual(1, appTest.PatientID);
            app.MedicalStaffID = 1;
            ml.UpdateAppointment(app);
        }

        /// <summary>
        /// Tests for AddAppointment method
        /// </summary>
        [TestMethod]
        public void MetalayerAddAppointment()
        { 
            app.AppDate = new DateTime(2017, 11, 12);
            app.AppTime = new DateTime(2017, 11, 12, 16, 15, 00);
            app.Notes = "Follow up";
            app.AppAttend = true;
            app.MedicalStaffID = 1;
            app.PatientID = 1;
            ml.AddAppointment(app);

            appList = ml.GetAppointments();
            appTest = appList[appList.Count -1];                                                                                            // Take the last list entry and store it in the test appointment
            Assert.AreEqual("Follow up", appTest.Notes);
            Assert.AreEqual(true, appTest.AppAttend);
            Assert.AreEqual(1, appTest.MedicalStaffID);
            Assert.AreEqual(1, appTest.PatientID);
            Assert.AreEqual(new DateTime(2017, 12, 13, 16, 15, 00), appTest.AppTime);
            Assert.AreEqual(new DateTime(2017, 11, 12), appTest.AppDate);
        }

        /// <summary>
        /// Tests the AddRota method
        /// </summary>
        [TestMethod]
        public void MetalayerAddRota()
        {
            rota.StaffID = 1;
            rota.StartTime = 161500;
            rota.Forename = "Linus";
            rota.Surname = "Torvild";
            rota.EndTime = 163500;
            rota.Days = "1";
            ml.AddRota(rota);

            rotaList = ml.GetStaffRota();
            rotaTest = rotaList.ElementAtOrDefault(0);                                                                                         // Take the last list entry and store it in the test rota
            Assert.AreEqual(true, rotaTest.Days.Contains("Mon"));
            Assert.AreEqual("Linus", rotaTest.Forename);
            Assert.AreEqual("Torvild", rotaTest.Surname);
        }

        /// <summary>
        /// Tests for GetStaffRotaByID method
        /// </summary>
        [TestMethod]
        public void MetalayerGetStaffRotaByID()
        {
            rota = new Rota();
            rota.RotaEntryID = 1;
            rotaList = ml.GetStaffRotaByID(rota);
            rotaTest = rotaList.ElementAtOrDefault(0);                                                                                         // Take the last list entry and store it in the test rota
            Assert.AreEqual("1", rotaTest.Days);
            Assert.AreEqual(1, rotaTest.StaffID);
        }

        /// <summary>
        /// Tests for UpdateRota method
        /// </summary>
        [TestMethod]
        public void MetalayerUpdateRota()
        {
            rota.RotaEntryID = 1;
            rota.StaffID = 1;
            rota.Days = "2";
            ml.UpdateRota(rota);

            rotaList = ml.GetStaffRotaByID(rota);
            rotaTest = rotaList.ElementAtOrDefault(0);                                                                                        // Take the last list entry and store it in the test rota
            Assert.AreEqual("2", rotaTest.Days);
        }

        /// <summary>
        /// Tests for GetMissedAppointments method
        /// </summary>
        [TestMethod]
        public void MetalayerGetMissedAppointments()
        {
            appList = ml.GetMissedAppointments();

            appTest = appList[appList.Count -1];                                                                                            // Take the last list entry and store it in the test appointment
            Assert.AreEqual(4, appTest.AppointmentID);
            Assert.AreEqual(false, appTest.AppAttend);
        }

        /// <summary>
        /// Tests for AddAddress method
        /// </summary>
        [TestMethod]
        public void MetalayerAddAddress()
        {
            add.HouseName = "name";
            add.HouseNumber = 22;
            add.PostCode = "PE433RE";
            add.StreetName = "Street";

            column = null;
            passedData = $"null, '{add.HouseName}', {add.HouseNumber}, '{add.StreetName}', '{add.PostCode}'";

            ml.AddAddress(add, column, passedData);

            addTest = ml.GetAddressById(6);
            Assert.AreEqual("name", addTest.HouseName);
            Assert.AreEqual(22, addTest.HouseNumber);
            Assert.AreEqual("Street", addTest.StreetName);
            Assert.AreEqual("PE433RE", addTest.PostCode);
        }

        /// <summary>
        /// Tests for AddMedicalStaff method
        /// </summary>
        [TestMethod]
        public void MetalayerAddMedicalStaff()
        {
            medStaff.Type = 1;
            medStaff.Forename = "Test";
            medStaff.Surname = "Testing";
            medStaff.Username = "tester";
            medStaff.PrescriptionLevel = 1;
            medStaff.Password = "password123";
            medStaff.PhoneNumber = "123456789";
            medStaff.Gender = 0;
            medStaff.EmailAddress = "test@test.com";
            medStaff.AddressID = 6;

            ml.AddMedicalStaff(medStaff);

            staffTest = ml.GetStaffByUserName(medStaff.Username);
            Assert.AreEqual("Test", staffTest.Forename);
            Assert.AreEqual("Testing", staffTest.Surname);
            Assert.AreEqual("tester", staffTest.Username);
            Assert.AreEqual("test@test.com", staffTest.EmailAddress);
            Assert.AreEqual(1, staffTest.Type);
            Assert.AreEqual(Convert.ToUInt32(6), staffTest.AddressID);

        }

        /// <summary>
        /// Tests for UpdateMedicalStaff method
        /// </summary>
        [TestMethod]
        public void MetalayerUpdateMedicalStaff()
        {
            medStaff.StaffID = 16;
            medStaff.Type = 1;
            medStaff.Forename = "TesterA";
            medStaff.PhoneNumber = "987654321";
            ml.UpdateMedicalStaff(medStaff);

            medStaffTest = (MedicalStaff) ml.GetStaffByUserName("tester");
            Assert.AreEqual("TesterA", medStaffTest.Forename);
            Assert.AreEqual("987654321", medStaffTest.PhoneNumber);
        }
        
        /// <summary>
        /// Tests for UpdateStaffMember method
        /// </summary>
        [TestMethod]
        public void MetalayerUpdateStaffMember()
        {
            staff = ml.GetStaffByUserName("tester");
            staff.Surname = "MoreTesting";
            ml.UpdateStaffMember(staff);

            staffTest = ml.GetStaffByUserName("tester");
            Assert.AreEqual("MoreTesting", staffTest.Surname);
        }
        
        /// <summary>
        /// Tests for DeleteStaff method
        /// </summary>
        [TestMethod]
        public void MetalayerDeleteStaff()
        { 
            staff = ml.GetStaffByUserName("tester");
            ml.DeleteStaff(staff);

            try
            {
                staffTest = new Staff();
                staffTest = null;
                staffTest = ml.GetStaffByUserName("tester");

                if (staffTest.Username == "tester")
                {
                    DeleteStaffCatch = "Found, DeleteStaff Fail";
                }
                else
                {
                    DeleteStaffCatch = "Not found, DeleteStaff pass";
                }
                
            }
            catch
            {
                DeleteStaffCatch = "Not found, DeleteStaff pass";
            }

            Assert.AreEqual("Not found, DeleteStaff pass", DeleteStaffCatch);

        }

        /// <summary>
        /// Tests for UpdateAddress method
        /// </summary>
        [TestMethod]
        public void MetalayerUpdateAddress()
        {
            add.AddressID = addTest.AddressID;
            add = ml.GetAddressById(6);
            add.HouseName = "testName";
            ml.UpdateAddress(add, 6);

            addTest = ml.GetAddressById(6);
            Assert.AreEqual("testName", addTest.HouseName);

        }

        /// <summary>
        /// Tests for DeleteAddress method
        /// </summary>
        [TestMethod]
        public void MetalayerDeleteAddress()
        {
            ml.DeleteAddress(6);

            try
            {
                addTest = new Address();
                addTest = null;
                addTest = ml.GetAddressById(6);

                if (addTest.HouseNumber == 22)
                {
                    DeleteAddressCatch = "Found, DeleteAddress Fail";
                }
                else
                {
                    DeleteAddressCatch = "Not found, DeleteAddress pass";
                }

            }
            catch
            {
                DeleteAddressCatch = "Not found, DeleteAddress pass";
            }

            Assert.AreEqual("Not found, DeleteAddress pass", DeleteAddressCatch);


        }

        /// <summary>
        /// Tests for GetMedicationByName method
        /// </summary>
        [TestMethod]
        public void MetalayerGetMedicationByName()
        { 
            medList = ml.GetMedicationByName("Asprin");

            medTest = medList[medList.Count -1];                                                                                          // Take the last list entry and store it in the test medication
            Assert.AreEqual("Asprin", medTest.Name);
            Assert.AreEqual(2, medTest.ID);

        }

        /// <summary>
        /// Tests for AddMedication method
        /// </summary>
        [TestMethod]
        public void MetalayerAddMedication()
        {
            med.Name = "TestMed";
            med.PermissionLevel = 2;
            med.Dosage = "50mg";
            ml.AddMedication(med);

            medList = ml.GetMedicationByName("TestMed");
            medTest = medList[medList.Count -1];                                                                                          // Take the last list entry and store it in the test medication
            Assert.AreEqual("TestMed", medTest.Name);
            Assert.AreEqual("50mg", medTest.Dosage);
            Assert.AreEqual(2, medTest.PermissionLevel);
        }

        /// <summary>
        /// Tests for UpdateMedication method
        /// </summary>
        [TestMethod]
        public void MetalayerUpdateMedication()
        { 
            med.ID = medTest.ID;
            med.Dosage = "500mg";
            ml.UpdateMedication(med);

            medList = ml.GetMedicationByName("TestMed");
            medTest = medList[medList.Count -1];                                                                                          // Take the last list entry and store it in the test medication
            Assert.AreEqual("TestMed", medTest.Name);
            Assert.AreEqual("500mg", medTest.Dosage);
            Assert.AreEqual(2, medTest.PermissionLevel);
        }

        /// <summary>
        /// Tests for DeleteMedication method
        /// </summary>
        [TestMethod]
        public void MetalayerDeleteMedication()
        {
            ml.DeleteMedication(med.ID);

            try
            {
                medList = new List<Medication>();
                medList = null;
                medList = ml.GetMedicationByName("TestMed");
                medTest = medList[medList.Count -1];                                                                                      // Take the last list entry and store it in the test medication

                if (medTest.Name == "TestMed")
                {
                    DeleteMedicationCatch = "Found, DeleteMedication Fail";
                }
                else
                {
                    DeleteMedicationCatch = "Not found, DeleteMedication pass";
                }

            }
            catch
            {
                DeleteMedicationCatch = "Not found, DeleteMedication pass";
            }

            Assert.AreEqual("Not found, DeleteMedication pass", DeleteMedicationCatch);

        }

    }
}
