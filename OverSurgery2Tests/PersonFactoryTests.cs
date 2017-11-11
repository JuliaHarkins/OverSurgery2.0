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
    public class PersonFactoryTests
    {
        [TestMethod()]
        public void CreatePatientTestIsOfTypePatient()
        {
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                        { "ID", 1 },
                        { "Forename", "Jacob" },
                        { "Surname", "Smith" },
                        { "Gender", 0 },
                        { "DateOfBirth", "17/09/1996" },
                        { "PhoneNumber", "056742097654" },
                        { "RegisteredDoctorID", 2 },
                        { "AddressID", 1 }
            };
            Patient TestPatient = Singletons.pf.CreatePatient(values);
            Assert.IsInstanceOfType(TestPatient, typeof(Patient));
        }
    }
}