using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public static class LogHelper
    {
        private static string logFolderName = "logs";
        public static Serilog.Core.Logger Log { get; private set; }
        //public static Serilog.Log Log = Serilog.Log;
        /// <summary>
        /// Setup Log.Logger
        /// </summary>
        /// <param name="logFileName">rename log file name, otherwise it uses log.txt</param>
        public static void SetupLogger(string logFileName = default)
        {
            var file = string.IsNullOrEmpty(logFileName) ? "log.txt" : logFileName;
            var logPath = Path.Combine(LogFolder, file);
            Log = new LoggerConfiguration().
                WriteTo.File(
                    logPath,
                    rollingInterval: RollingInterval.Hour,
                    rollOnFileSizeLimit: true,
                    retainedFileCountLimit: 3
                ).CreateLogger();
            Serilog.Log.Logger = Log;

            //Log.Information($"Rhino: {Rhino.RhinoApp.ExeVersion}.{Rhino.RhinoApp.ExeServiceRelease} ({Rhino.RhinoApp.BuildDate})");
            //Log.Information(Utility.GetAboutInfo());
        }

        public static string LogFolder
        {
            get
            {
                var userAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var podir = Path.Combine(userAppData, "pollination");
                if (!Directory.Exists(podir))
                    Directory.CreateDirectory(podir);

                podir = Path.Combine(podir, logFolderName);
                if (!Directory.Exists(podir))
                    Directory.CreateDirectory(podir);
                return podir;
            }
        }

        public static string GetTheLatestLog()
        {
            var folder = new DirectoryInfo(LogFolder);
            if (!folder.Exists) return null;

            var lastLog = folder.GetFiles().OrderBy(_ => _.LastWriteTime).LastOrDefault();
            if (lastLog.Exists) return lastLog.FullName;
            else return null;

        }



    }
}
