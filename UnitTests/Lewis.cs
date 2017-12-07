using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass()]
    public class Lewis
    {
        LoginController lc = LoginController.Instance();
        MetaLayer ml = MetaLayer.Instance();
        [TestMethod()]
        public void TestSuccessfulLogin()
        {
            Dictionary<string, string> login = new Dictionary<string, string>
            {
                {"Username", "Manager"},
                {"Password", lc.HashPassword("password123")}
            };
            Assert.IsTrue(lc.ValidateLogin(login));
        }
        [TestMethod()]
        public void TestFailedLogin()
        {
            Dictionary<string, string> login = new Dictionary<string, string>
            {
                {"Username", "Manager"},
                {"Password", lc.HashPassword("egggsssrool")}
            };
            Assert.IsFalse(lc.ValidateLogin(login));
        }

        [TestMethod()]
        public void TestMetaLayerGetPatients()
        {
            List<Patient> patients = ml.GetPatients();
            Assert.AreNotEqual(0,patients.Count);
        }
    }
}