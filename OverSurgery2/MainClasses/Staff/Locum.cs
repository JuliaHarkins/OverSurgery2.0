﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class Locum : MedicalStaff
    {
        public Locum(Dictionary<string,object> p_medicalStaffValues) :base(p_medicalStaffValues)
        {
        }
    }
}
