using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery2;

namespace UnitTests
{
    [TestClass]
    public class Ed
    {
        RotaForm rf = new RotaForm(); // No public methods! & it's a form
        MedicalStaff ms = new MedicalStaff(); // No references to Method!
        Medication m = new Medication(); // No functioning Methods!
        UpdateRota ur = new UpdateRota(0, new string[] {"",""}, new bool[] {false}); // No public methods! & it's a form
        [TestMethod]
        public void RotaForm()
        {
            //
        }
        [TestMethod]
        public void MedicalStaff()
        {
            //
        }

        [TestMethod]
        public void Medication()
        {
            //
        }

        [TestMethod]
        public void UpdateRota()
        {
            //
        }
    }
}
