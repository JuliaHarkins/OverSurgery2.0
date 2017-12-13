using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoggingSystem.Time;

namespace LoggingSystem
{
    public class PerfLog
    {
        private static PerfLog m_perfLog;
        private StringBuilder m_bufferString = new StringBuilder();
        private StringBuilder m_writeString = new StringBuilder();
        private string m_sessionID;
        private string m_startLine = "###################### [BEGIN LOG] ######################";
        private string m_endLine = "======================  [END LOG]  ======================";
        private bool perfStarted;
        private bool subPerfStarted;
        private string m_logStart = $"\t\t $$ START LOG $$\r\n";

        public string SessionID { get { return perf().m_sessionID; } set { perf().m_sessionID = value; } }
        private StringBuilder BufferString { get { return m_bufferString; } set { m_bufferString = value; } }

        public static PerfLog perf()
        {
            if (m_perfLog == null)
            {
                m_perfLog = new PerfLog();
            }
            return m_perfLog;
        }

        public string LogHeader()
        {
            return $"{m_startLine}\r\nSessionID : {SessionID}\r\n{m_logStart}";
        }

        public static void PerfStart()
        {
            perf().perfStarted = true;
            time().Elapsed = 0;
            PerfTimer(true);
        }

        public static void PerfStop(string className)
        {
            if (perf().perfStarted)
            {
                PerfTimer(false);
                perf().BufferString.Append($"{className} - {time().Elapsed}ms\r\n");
                perf().perfStarted = false;
            }
            else
            {
                MessageBox.Show("Timer Has Not Been Started");
            }
        }

        public static void SubPerfStart()
        {
            perf().subPerfStarted = true;
            time().Elapsed = 0;
            PerfTimer(true);
        }

        public static void SubPerfStop(string methodName)
        {
            if (perf().subPerfStarted)
            {
                PerfTimer(false);
                perf().BufferString.Append($"\t{methodName} - {time().Elapsed}ms\r\n");
                perf().subPerfStarted = false;
            }
            else
            {
                MessageBox.Show("Timer Has Not Been Started");
            }
        }
        public void WritePerfLog()
        {
                m_writeString = BufferString;
                CompileWrite();
        }
        private void CompileWrite()
        {
            StreamWriter streamWriter = new StreamWriter("PerfLog.txt", append: true);
            streamWriter.WriteAsync("\r\n" + LogHeader() + "\r\n" + m_writeString.ToString() + "\r\n" + m_endLine + "\r\n");
            BufferString.Clear();
            streamWriter.Close();
        }
    }
}
