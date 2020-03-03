using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dicom.Log;
using Serilog;
using Serilog.Enrichers;

namespace SuH_FoDicom
{
    public static class SH_Serilog
    {


        private static SerilogManager UseSpecificSerilogLogger()
        {
            //Get a Serilog logger instance
            var logger = ConfigureLogging();

            //Wrap it in some extra context as an example
            logger = logger.ForContext("Purpose", "Demonstration");

            //Configure fo-dicom & Serilog
            return new SerilogManager(logger);
        }

        public static SerilogManager UseGlobalSerilogLogger()
        {
            //Configure logging
            ConfigureLogging();

            //Configure fo-dicom & Serilog
            return new SerilogManager();
        }


        /// <summary>
        /// Create and return a serilog ILogger instance.  
        /// For convenience this also sets the global Serilog.Log instance
        /// </summary>
        /// <returns></returns>
        public static ILogger ConfigureLogging()
        {
            var loggerConfig = new LoggerConfiguration()
                //Enrich each log message with the machine name
                .Enrich.With<MachineNameEnricher>()
                //Accept verbose output  (there is effectively no filter)
                .MinimumLevel.Verbose()
                //Write out to the console using the "Literate" console sink (colours the text based on the logged type)
                //.WriteTo.LiterateConsole()
                //Also write out to a file based on the date and restrict these writes to warnings or worse (warning, error, fatal)
                .WriteTo.RollingFile(@"Warnings_{Date}.txt", global::Serilog.Events.LogEventLevel.Verbose);

            //if (useSeq)
            //{
            //    //Send events to a default installation of Seq on the local computer
            //    loggerConfig = loggerConfig.WriteTo.Seq("http://localhost:5341");
            //}

            var logger = loggerConfig
                //Take all of that configuration and make a logger
                .CreateLogger();

            //Stash the logger in the global Log instance for convenience
            global::Serilog.Log.Logger = logger;

            return logger;
        }
    }
}
