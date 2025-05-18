using Microsoft.Extensions.Logging;
using System;

namespace ConsoleAppDemo
{
    internal static class LogUtils
    {
        private static string _logCatagory = $"ConsoleAppDemo";

        private static PollinationLogger.LogHelper? _helper;
        internal static PollinationLogger.LogHelper Helper => _helper ??= new PollinationLogger.LogHelper(_logCatagory);

        internal static ILogger GetLogger<T>() => Helper.GetLoggerOptional<T>();
        internal static ILogger GetLogger(Type type) => Helper.GetLoggerOptional(type);
        internal static ILogger GetLogger(string catName) => Helper.GetLoggerOptional(catName);

        internal static ILogger Logger => GetLogger(_logCatagory);
    }

}
