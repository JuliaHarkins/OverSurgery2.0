using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2.Tests
{
    [TestClass()]
    public class MetaLayerTests
    {
        [TestMethod()]
        public void InstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPatientsTestIsInstanceOfTypeList()
        {
            var testPatients = MetaLayer.Instance().GetPatients();
            Assert.IsInstanceOfType(testPatients, typeof(List<Patient>));
        }

        [TestMethod()]
        public void GetPatientsTestIsNotNull()
        {
            var testPatients = MetaLayer.Instance().GetPatients();
            Assert.IsNotNull(testPatients); ;
        }

        [TestMethod()]
        public void GetLoginTestIsInstanceofTypeTuple()
        {
            var testLogin = MetaLayer.Instance().GetLogin("Receptionist");
            Assert.IsInstanceOfType(testLogin, typeof(Tuple<string,string,int?>));
        }

        [TestMethod()]
        public void GetLoginTestIsNotNull()
        {
            var testLogin = MetaLayer.Instance().GetLogin("Receptionist");
            Assert.IsNotNull(testLogin);
        }

        [TestMethod()]
        public void GetMedicationTestIsInstanceOfTypeList()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMedicalStaffNameByIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPatientByIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertNewPatientTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAddressByIDTestIsInstanceOfTypeString()
        {
            var testAddress = MetaLayer.Instance().GetAddressByID(1);
            Assert.IsInstanceOfType(testAddress, typeof(string));
        }

        [TestMethod()]
        public void GetStaffEmailByUserNameTestIsInstanceOfTypeString()
        {
            var testEmail = MetaLayer.Instance().GetStaffEmailByUserName("Receptionist");
            Assert.IsInstanceOfType(testEmail, typeof(string));
        }

        [TestMethod()]
        public void GetStaffByUserNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetResetRequestCodeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NewResetRequestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateStaffPasswordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteResetRequestTestReturnFalse()
        {
            Assert.IsFalse(MetaLayer.Instance().DeleteResetRequest("testUser"));
        }

        [TestMethod()]
        public void GetPatientByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAppointmentByPatientIdTest()
        {
            Assert.Fail();
        }
    }
}