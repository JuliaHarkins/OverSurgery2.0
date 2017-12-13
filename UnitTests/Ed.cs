using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;
using OverSurgery2.UserInterface;

namespace UnitTests
{
    [TestClass]
    public class Ed
    {
        MetaLayer ml = MetaLayer.Instance();
        [TestMethod]
        public void MetalayerTest_ReturnPatientAddress()
        {
            Tuple<List<int>, List<string>, List<string>, List<string>, List<int>, List<string>, List<string>> returnPatientAddress = 
                ml.SelectPatientAddress("Forename = 'Amy' AND Surname = 'Adams'");
            Assert.AreEqual(3, returnPatientAddress.Item1.ElementAtOrDefault(0));
            Assert.AreEqual("Amy", returnPatientAddress.Item2.ElementAtOrDefault(0));
            Assert.AreEqual("Adams", returnPatientAddress.Item3.ElementAtOrDefault(0));
            Assert.AreEqual("Trial", returnPatientAddress.Item4.ElementAtOrDefault(0));
            Assert.AreEqual(0, returnPatientAddress.Item5.ElementAtOrDefault(0));
            Assert.AreEqual("B THIS IS A TEST", returnPatientAddress.Item6.ElementAtOrDefault(0));
            Assert.AreEqual("01 TEST 10", returnPatientAddress.Item7.ElementAtOrDefault(0));
        }

        [TestMethod]
        public void MetalayerTest_GetLogin()
        {
            Tuple<string, string, int?> userCredentials = ml.GetLogin("Manager");
            Assert.AreEqual("Manager", userCredentials.Item1);
            Assert.AreEqual("$2a$13$/8Wncr26eAmxD1l6cAF9FuGh9peis64eMEcl3c6s/qJjluxZ63V8a", userCredentials.Item2);
            Assert.AreEqual(5, userCredentials.Item3);
        }

        [TestMethod]
        public void GetPatientID_Test()
        {
            NewAppointmentFormBackEnd npb = new NewAppointmentFormBackEnd();
            List<int> patientID = npb.Selection(forename: "Amy", surname: "Adams");
            Assert.AreEqual(3, patientID.ElementAtOrDefault(0));
        }

        [TestMethod]
        public void SelectMedicalStaff_Test()
        {
            string tables = "Staff s, Rota r, DayOfWeek d";
            string searchParam = "s.StaffID = ms.StaffID AND r.StaffID = s.StaffID AND r.StaffID = ms.StaffID AND r.DayID = d.DayID AND DayName = 'Thur'";
            Tuple<List<string>, List<string>, List<string>> medicalStaff = ml.SelectMedicalStaff_WithDateAddOn(tables: tables, searchParam: searchParam);
            Assert.AreEqual("Locum", medicalStaff.Item1.ElementAtOrDefault(0));
            Assert.AreEqual("Test", medicalStaff.Item2.ElementAtOrDefault(0));
            Assert.AreEqual("M", medicalStaff.Item3.ElementAtOrDefault(0));
        }
    }
}
