﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public class Locum : MedicalStaff
    {
        public Locum(Dictionary<string,object> p_medicalStaffValues) :base(p_medicalStaffValues)
        {
            PrescriptionLevel = 2;
        }
    }
}
