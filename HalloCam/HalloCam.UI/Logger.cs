using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloCam.UI
{
    class Logger
    {
        public static void Log(string msg)
        {
            Trace.WriteLine($"[{DateTime.Now}] ({Environment.UserName}) {msg}");
        }
    }
}
