using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static LoggingSystem.PerfLog;

namespace LoggingSystem
{
    class GenLog
    {
        private StringBuilder m_bufferString = new StringBuilder();
        private StringBuilder m_writeString = new StringBuilder();
        private string m_username;
        private string m_password;
        private DateTime m_startTime;
        private DateTime m_endTime;
        private string m_startLine = "###################### [BEGIN LOG] ######################";
        private string m_endLine = "======================  [END LOG]  ======================";
        private string m_logInfo;
        private string m_sessionID;
        private bool sessionActive;
        private static GenLog m_log;
        private static Random rand;

        private DateTime StartTime { get { return m_startTime; } set { m_startTime = value; } }
        private DateTime EndTime { get { return m_endTime; } set { m_endTime = value; } }
        private string SessionID { get { return m_sessionID; } set { m_sessionID = value; } }
        private StringBuilder BufferString { get { return m_bufferString; } set { m_bufferString = value; }}

        public static GenLog log()
        {
            if (m_log == null)
            {
                m_log = new GenLog();
            }
            return m_log;
        }

        public static void GenerateSessionID()
        {
            if (log().SessionID == null)
            {
                rand = new Random();
                perf().SessionID = log().SessionID = rand.Next(0, 10).ToString() + rand.Next(0, 10).ToString() +
                                  rand.Next(0, 10).ToString() + 'x' + rand.Next(0, 10).ToString() +
                                  rand.Next(0, 10).ToString() + rand.Next(0, 10);
            }
        }

        public static void ClearSession()
        {
            perf().SessionID = log().SessionID = null;
        }

        public static void Write(string LogString)
        {
            log().BufferString.Append(LogString).AppendLine("\r\n");
        }

        public static void StartLog()
        {
            log().StartTime = DateTime.Now;
            log().sessionActive = true;
        }

        public static void ReferenceLog(string username, string password, bool success)
        {
            log().m_username = null;
            log().m_password = null;
            if (success)
            {
                log().m_username = username;
                log().m_password = "[yes]";
            }
            else
            {
                log().m_username = username;
                log().m_password = password;
            }

        }

        private void LogInfo(string username, string password)
        {
            m_logInfo = $"SessionID : {log().SessionID}\r\n" +
                             $"Session Start Time : {log().StartTime}\r\n" +
                             $"Session End Time : {log().EndTime}\r\n" +
                             $"Username : {username}\r\n" +
                             $"Using Password : {password}\r\n\r\n" +
                             $"\t\t $$ START LOG $$\r\n";
        }

        public static void LogBody(string logBody)
        {
            log().BufferString.Append($"\t{logBody}\r\n");
        }

        public static void EndLog()
        {
            log().EndTime = DateTime.Now;
            log().LogInfo(log().m_username, log().m_password);
            log().sessionActive = false;
            log().BufferToWriter();
        }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            return stackFrame.GetMethod().Name;
        }

        private void BufferToWriter()
        {
            if (!sessionActive)
            {
                m_writeString = BufferString;
                CompileWrite();
            }
        }

        private void CompileWrite()
        {
            StreamWriter streamWriter = new StreamWriter("GenLog.txt", append: true);
            streamWriter.WriteAsync("\r\n" + m_startLine + "\r\n" + m_logInfo + "\r\n" + m_writeString.ToString() + m_endLine + "\r\n");
            BufferString.Clear();
            streamWriter.Close();
        }
    }
}
