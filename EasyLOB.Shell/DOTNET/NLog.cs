using NLog;
using System;

namespace EasyLOB.Shell
{
    partial class Program
    {
        private static void DOTNETNLogDemo()
        {
            Console.WriteLine("\nNLog Demo");

            /*
            * Fatal
            * Error
            * Warn
            * Info
            * Debug
            * Trace
            * Off
            */

            int d = DateTime.Today.Day;
            int ym = DateTime.Today.Year * 100 + DateTime.Today.Month;

            Logger logger = LogManager.GetLogger("NLog");

            logger.Log(LogLevel.Info, "Sample informational message with LogLevel");
            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");

            logger.Log(LogLevel.Info, "Sample informational message, d={0}, ym={1}", d, ym);
            logger.Trace("Sample trace message, d={0}, ym={1}", d, ym);
            logger.Debug("Sample debug message, d={0}, ym={1}", d, ym);
            logger.Info("Sample informational message, d={0}, ym={1}", d, ym);
            logger.Warn("Sample warning message, d={0}, ym={1}", d, ym);
            logger.Error("Sample error message, d={0}, ym={1}", d, ym);
            logger.Fatal("Sample fatal error message, d={0}, ym={1}", d, ym);
        }
    }
}