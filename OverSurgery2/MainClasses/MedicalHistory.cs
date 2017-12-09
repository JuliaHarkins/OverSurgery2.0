using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
    /// Created By: J
    /// Date Created : 31/10/17
    /// </summary>
    public class MedicalHistory
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int PatientID { get; set; }
        
        public MedicalHistory()
        {
        }
    }
}


