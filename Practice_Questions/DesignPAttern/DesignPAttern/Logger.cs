using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPAttern
{
    public class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();

        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }
    }
}
