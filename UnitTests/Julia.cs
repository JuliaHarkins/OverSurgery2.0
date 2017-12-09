using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;

namespace UnitTests
{
    [TestClass]
    public class Julia
    {
        MetaLayer ml = MetaLayer.Instance();
        List<Medication> medications = new List<Medication>();
        List<Prescription> prescriptions = new List<Prescription>();
        List<Extension> extensions = new List<Extension>();
        List<MedicalHistory> medicalHistoy = new List<MedicalHistory>();
        List<Appointment> appointments = new List<Appointment>();
        int i;
        string s;

        [TestMethod]
        public void GetMedicationOnMedStaffID()
        {
            medications = ml.GetMedicationOnMedStaffID(3);
            Assert.AreEqual(medications[0].Name, "Asprin");
            Assert.AreEqual(medications[1].Name, "Ibruprofen");
        }

        [TestMethod]
        public void GetPatientsPrescriptions()
        {
            prescriptions = ml.GetPatientsPrescriptions(2);
            Assert.AreEqual(prescriptions[0].Amount, 32);
        }
        [TestMethod]
        public void DoctorExtentionCount()
        {
            i = ml.DoctorExtentionCount(4);
            Assert.AreEqual(i, 10);
        }

        [TestMethod]
        public void GetExtentedPrescriptions()
        {
            prescriptions= ml.GetExtentedPrescriptions(4);
            Assert.AreEqual(prescriptions.Count, 10);
        }

        [TestMethod]
        public void GetExtentionRequests()
        {
            extensions = ml.GetExtentionRequests(4);
            Assert.AreEqual(extensions.Count, 10);
        }

        [TestMethod]
        public void GetPatientsMedicalHiatory()
        {
            medicalHistoy = ml.GetPatientsMedicalHistory(3);
            Assert.AreEqual(medicalHistoy.Count, 7);
        }
        
        [TestMethod]
        public void GetMedicationName()
        {
            s = ml.GetMedicationName(2);
            Assert.AreEqual(s, "Asprin");
        }

        [TestMethod]
        public void GetStaffIDFromMedStaffID()
        {
            i = ml.GetStaffIDFromMedStaffID(4);
            Assert.AreEqual(i, 7);
        }
        [TestMethod]
        public void GetStaffNameAndTitle()
        {
            s = ml.GetStaffNameAndTitle(4);
            Assert.AreEqual(s, "Nurse Test Trial");
        }
    }
}
