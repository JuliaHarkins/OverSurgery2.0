using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LoggingSystem
{
    class Time
    {
        private double m_elapsed = 0;
        private static Time m_time;

        public double Elapsed { get { return m_elapsed; } set { m_elapsed = value; } }
        public Timer PerTimer { get; set; }

        public static Time time()
        {
            if (m_time == null)
            {
                m_time = new Time();
            }
            return m_time;
        }

        public static void PerfTimer(bool running)
        {
            time().PerTimer = new Timer();
            time().PerTimer.AutoReset = true;
            time().PerTimer.Enabled = running;
            time().PerTimer.Interval = 0.1;
            time().PerTimer.Elapsed += time().ElapsedTime;
        }

        private void ElapsedTime(Object source, ElapsedEventArgs e)
        {
            Elapsed += 0.1;
        }
    }
}
