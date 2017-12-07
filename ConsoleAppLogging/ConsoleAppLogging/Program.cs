using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logging is fun");
            VNC.AppLog.Info("Hello", "MyApp");
            Console.ReadLine();
        }
    }
}
