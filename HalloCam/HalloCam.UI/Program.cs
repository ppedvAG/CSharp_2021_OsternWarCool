using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloCam.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
            //Trace.Listeners.Add(new EventLogTraceListener("Application"));
            Trace.AutoFlush = true;
            Logger.Log("HalloCam wurde gestartet");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
