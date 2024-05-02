extern alias LBTNewtonsoft; extern alias LBTRestSharp;
using System.Runtime.CompilerServices;
using System;

namespace PollinationSDK
{
    public static class LogHelper
    {
        public static Serilog.ILogger Logger
        {
            get => Helper.Logger;
            set => Helper.Logger = value;
        }

        public static void LogInfo(string message, [CallerMemberName] string memberName = "")
        {
            Logger?.Information("{memberName}:{message}", memberName, message);
        }
        public static void LogWarning(string message, [CallerMemberName] string memberName = "")
        {
            Logger?.Warning("{memberName}:{message}", memberName, message);
        }

        public static void LogError(string ex, [CallerMemberName] string memberName = "")
        {
            Logger?.Error("{memberName}:{ex}", memberName, ex);
        }

        public static void LogError(Exception ex, [CallerMemberName] string memberName = "")
        {
            Logger?.Error(ex, "{memberName}", memberName);
        }

        /// <summary>
        /// Log and throw the error
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        public static void LogThrowError(string ex, [CallerMemberName] string memberName = "")
        {
            LogThrowError(new ArgumentException(ex), memberName);
        }

        /// <summary>
        /// Log and throw the error
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="memberName"></param>
        public static void LogThrowError(Exception ex, [CallerMemberName] string memberName = "")
        {
            Logger?.Error(ex, "{memberName}", memberName);
            throw ex;
        }

        public static Exception LogReturnError(string ex, [CallerMemberName] string memberName = "")
        {
            return LogReturnError(new ArgumentException(ex), memberName);
        }

        public static Exception LogReturnError(Exception ex, [CallerMemberName] string memberName = "")
        {
            Logger?.Error(ex, "{memberName}", memberName);
            return ex;
        }

    }

}
