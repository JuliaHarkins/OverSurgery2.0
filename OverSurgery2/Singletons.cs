using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    public static class Singletons
    {
        public static MetaLayer ml = MetaLayer.Instance();
        public static PersonFactory pf = PersonFactory.Instance();
        public static LoginController lc = LoginController.Instance();
        public static PatientController pc = PatientController.Instance();
        public static FormController fc = FormController.Instance();
    }
}

