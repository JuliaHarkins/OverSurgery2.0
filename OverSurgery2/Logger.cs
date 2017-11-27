using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery2
{
    /// <summary>
    /// Allows the logging of events for later reference
    /// <example>This example shows you how to use this class
    /// <c>Logger.GetLogger().{Method Name Here};</c></example>
    /// </summary>
    public class Logger
    {
        private static Logger m_Logger;
        private List<LoggerEvent> m_Logs = new List<LoggerEvent>();
        private Logger()
        {

        }
        public static Logger GetLogger()
        {
            if (null == m_Logger)
            {
                m_Logger = new Logger();
            }
            return m_Logger;
        }
        /// <summary>
        /// Add a LoggerEvent to the list of logs;
        /// </summary>
        /// <param name="p_Event"></param>
        public void AddLog(LoggerEvent p_Event)
        {
            m_Logs.Add(p_Event);
        }
        
        /// <summary>
        /// Get the entire list of Logs
        /// </summary>
        /// <returns>Returns the entire list of logs</returns>
        public List<LoggerEvent> GetLogs() { return m_Logs; }
        /// <summary>
        /// Get the most recent log added
        /// </summary>
        /// <returns>Returns the most recent log added</returns>
        public LoggerEvent GetMostRecent() { return m_Logs.Last(); }
    }

    public class LoggerEvent
    {
        DateTime m_LogTime;
        LogType m_LogType;
        string m_UserName;
        string m_LogMessage;
        
        public LoggerEvent(DateTime p_LogTime, LogType p_LogType, string p_UserName, string p_LogMessage)
        {
            m_LogMessage = p_LogMessage;
            m_LogTime = p_LogTime;
            m_LogType = p_LogType;
            m_UserName = p_UserName;
        }

    }
    public enum LogType
    {
        Add,
        Remove,
        Edit,
        Cancel,
        Login,
        Logout,
        PasswordChange,
        PasswordResetRequest,
        FailedPasswordChange
    }
}
