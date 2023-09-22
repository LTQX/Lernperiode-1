using System;

namespace CockClock;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Time:" + DateTime.Now.ToString("HH:mm:ss:"));
            Thread.Sleep(1000);
            Console.Write(new string(' ', Console.WindowWidth));
        }
    }
}