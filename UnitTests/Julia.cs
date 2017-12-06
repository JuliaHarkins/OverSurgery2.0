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
        List<Medication> medicatinoList = new List<Medication>();
        
        public void Querries()
        {
            medicatinoList = ml.getMedicationOnMedStaffID(3);
            Assert.AreEqual(medicatinoList[0].Name,"Asprin");
        }
    }
}
