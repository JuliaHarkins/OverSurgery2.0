using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class Extension
    {
        public int ExtentionID{get; set;}
        public int Extended { get; set; }
        public int PrescriptionID { get; set; }
        public DateTime DateOfExtension { get; set; }
        public int MedicalStaffID { get; set; }
        public string Reason { get; set; }

        public Extension()
        {

        }
    }
}
