using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace WriteLog
{
    public class Program
    {
        private static readonly ILog logger = LogManager.GetLogger("PETER");
        // PETER Tên Log sẽ xuất hiện trong file LOG. Chỗ này có thể để tên Class, hoặc tên hệ thống

        static void Main(string[] args)
        {
            WriteLog("THIS IS A MESSAGE ERROR");
            Log4NET();
        }

        public static void WriteLog(string message)
        {
            try
            {
                string folderLog = Environment.CurrentDirectory + "\\LOGS";
                string location = folderLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                if (!Directory.Exists(folderLog))
                {
                    Directory.CreateDirectory(folderLog);
                }

                if (!File.Exists(location))
                {
                    FileStream fs = File.Create(location);
                    fs.Close();
                }
                StreamWriter sw = new StreamWriter(location, true);
                sw.Write(DateTime.Now.ToString() + " - " + message + Environment.NewLine);
                sw.Close();
                sw = null;
            }
            catch (Exception){}
        }

        public static void Log4NET()
        {
            // Download dll log4net
            // https://logging.apache.org/log4net/download_log4net.cgi

            // Cấu hình log4net
            // 1. Cấu hình trong file AssemblyInfo.cs (Properties) để trỏ tới file config log4net
            // [assembly: log4net.Config.XmlConfigurator(Watch = true)]
            // [assembly: log4net.Config.XmlConfigurator(ConfigFile="App.config", Watch = true)]
            // 2. Cấu hình trong file App.config
            /*<configSections>
              <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
            </configSections>
            <log4net>
              <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
                <file value="D:\\LOGS\\LOG.txt" />
                <appendToFile value="true" />
                <rollingStyle value="Size" />
                <maxSizeRollBackups value="10" />
                <maximumFileSize valssue="10MB" />
                <layout type="log4net.Layout.PatternLayout">
                  <conversionPattern value="%date [%thread] %-5level %logger - %message%newline" />
                </layout>
              </appender>
              <appender name="MemoryAppender" type="log4net.Appender.MemoryAppender">
              </appender>
              <root>
                <level value="Info" />
                <appender-ref ref="RollingLogFileAppender" />
                <appender-ref ref="MemoryAppender" />
              </root>
            </log4net>  */
            logger.Error("LOG HERE");
        }
    }
}
