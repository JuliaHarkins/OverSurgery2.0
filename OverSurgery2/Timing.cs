using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace OverSurgery2
{
    class Timing
    {
        public static Timer updateDataFromDatabase; // Timer used To controll GUI update

        private static void Times()
        {
            updateDataFromDatabase = new Timer()
            {
                Interval = 5000,
                AutoReset = false,
                Enabled = false
            };
            updateDataFromDatabase.Elapsed += UpdateData;
        }

        private static void UpdateData(Object source, ElapsedEventArgs e)
        {
            FormController fc = FormController.Instance();
            fc.UpdateData();
        }
    }
}
