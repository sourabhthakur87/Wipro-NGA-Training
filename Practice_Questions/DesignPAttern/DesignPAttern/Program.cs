using System;
using DesignPAttern;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Application started.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Logging another message.");

            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger instances are the same (Singleton verified).");
            }
            else
            {
                Console.WriteLine("Logger instances are different (Singleton failed).");
            }
        }
    }
}
