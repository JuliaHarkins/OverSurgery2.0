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

        [TestMethod()]
        public void CreateStaffTestIsOfTypeStaff()
        {
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "ID", "1" },
                { "Forename", "Jacob" },
                { "Surname", "Smith" },
                { "Email", "test@email.com" },
                { "AddressID", 2 },
                { "UserName", "testuser"},
                { "Password", "testpass"},
                { "Type", 3 },
                { "Gender", 0 },
                { "PhoneNumber", "056742097654"  }
            };
            Staff TestStaff = Singletons.pf.CreateStaff(values);
            Assert.IsInstanceOfType(TestStaff, typeof(Staff));
        }

        [TestMethod()]
        public void CreateStaffTestIsOfTypeDoctor()
        {
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "ID", "1" },
                { "Forename", "Jacob" },
                { "Surname", "Smith" },
                { "Email", "test@email.com" },
                { "AddressID", 2 },
                { "UserName", "testuser"},
                { "Password", "testpass"},
                { "Type", 3 },
                { "Gender", 0 },
                { "PhoneNumber", "056742097654"  }
            };
            Staff TestStaff = Singletons.pf.CreateStaff(values);
            Assert.IsInstanceOfType(TestStaff, typeof(Doctor));
        }

        [TestMethod()]
        public void CreateStaffTestIsOfTypeReceptionist()
        {
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "ID", "1" },
                { "Forename", "Jacob" },
                { "Surname", "Smith" },
                { "Email", "test@email.com" },
                { "AddressID", 2 },
                { "UserName", "testuser"},
                { "Password", "testpass"},
                { "Type", 4 },
                { "Gender", 0 },
                { "PhoneNumber", "056742097654"  }
            };
            Staff TestStaff = Singletons.pf.CreateStaff(values);
            Assert.IsInstanceOfType(TestStaff, typeof(Receptionist));
        }

        [TestMethod()]
        public void CreateStaffTestIsOfTypeLocum()
        {

            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "ID", "1" },
                { "Forename", "Jacob" },
                { "Surname", "Smith" },
                { "Email", "test@email.com" },
                { "AddressID", 2 },
                { "UserName", "testuser"},
                { "Password", "testpass"},
                { "Type", 2 },
                { "Gender", 0 },
                { "PhoneNumber", "056742097654"  }
            };
            Staff TestStaff = Singletons.pf.CreateStaff(values);
            Assert.IsInstanceOfType(TestStaff, typeof(Locum));
        }
    }
}