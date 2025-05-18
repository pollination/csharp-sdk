using Serilog.Extensions.Logging;
using Serilog;
using System.IO;
using Serilog.Core;
using Serilog.Events;
using System.Linq;
using System;

namespace ConsoleAppDemo
{
    public static class LogSetup
    {
        private static string _logFilePath;
        private static LoggingLevelSwitch _levelSwitch = new LoggingLevelSwitch(LogEventLevel.Information); // Initial level
     
        public static string LogFolder
        {
            get
            {
                var userAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var podir = Path.Combine(userAppData, "pollination", "log");
                if (!Directory.Exists(podir))
                    Directory.CreateDirectory(podir);
                return podir;
            }
        }

        public static void OneTimeSetup(string logFileName = default)
        {
            var file = string.IsNullOrEmpty(logFileName) ? "log.txt" : logFileName;

            _logFilePath = Path.Combine(LogFolder, file);

            Serilog.Log.Logger = new Serilog.LoggerConfiguration()
                .MinimumLevel.ControlledBy(_levelSwitch)
                //.Enrich.FromLogContext()
                //.Enrich.With<CallingContextEnricher>()
                .WriteTo.File(
                    _logFilePath,
                    rollingInterval: RollingInterval.Hour,
                    rollOnFileSizeLimit: true,
                    retainedFileCountLimit: 5,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {Properties:j}{NewLine}"
                ).CreateLogger();

            var loggerFactory = new SerilogLoggerFactory(Serilog.Log.Logger);
            PollinationLogger.LogHelper.OneTimeSetup(loggerFactory);
        }

        public static string GetTheLatestLog()
        {
            var folder = new DirectoryInfo(LogFolder);
            if (!folder.Exists) return "";

            var lastLog = folder.GetFiles().OrderBy(_ => _.LastWriteTime).LastOrDefault();
            if (lastLog != null && lastLog.Exists) return lastLog.FullName;
            else return "";
        }

        public static void SetLogLevel(LogEventLevel level)
        {
            _levelSwitch.MinimumLevel = level;
        }

        public static void Dispose()
        {
            if (!string.IsNullOrEmpty(_logFilePath))
            {
                Log.CloseAndFlush();
            }

        }
    }
}
