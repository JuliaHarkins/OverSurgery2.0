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

        [TestMethod]
        private void GetMedicationOnMedStaffID()
        {
            medications = ml.GetMedicationOnMedStaffID(3);
            Assert.AreEqual(medications[0].Name, "Asprin");
            Assert.AreEqual(medications[1].Name, "Ibruprofen");
        }

        [TestMethod]
        private void GetPatientsPrescriptions()
        {
            prescriptions = ml.GetPatientsPrescriptions(2);
            Assert.AreEqual(prescriptions[0].Amount, 32);
        }

        [TestMethod]
        private void DoctorExtentionCount()
        {
            int i = ml.DoctorExtentionCount(4);
            Assert.AreEqual(i, 10);
        }

        [TestMethod]
        private void GetExtentedPrescriptions()
        {
            prescriptions= ml.GetExtentedPrescriptions(4);
            Assert.AreEqual(prescriptions.Count, 10);
        }

        [TestMethod]
        private void GetExtentionRequests()
        {
            extensions = ml.GetExtentionRequests(4);
            Assert.AreEqual(extensions.Count, 10);
        }

        [TestMethod]
        private void GetPatientsMedicalHiatory()
        {
            medicalHistoy = ml.GetPatientsMedicalHiatory(3);
            Assert.AreEqual(medicalHistoy.Count, 7);
        }
        
        [TestMethod]
        private void GetMedicationName()
        {

        }
    }
}
