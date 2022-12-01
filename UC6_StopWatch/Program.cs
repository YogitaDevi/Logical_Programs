using System;
using System.Diagnostics;
using System.Threading;

namespace UC6_StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopW = new Stopwatch();
            stopW.Start();
            Thread.Sleep(7834);
            stopW.Stop();
            TimeSpan tspan = stopW.Elapsed;
            string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}:{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            Console.WriteLine(" Elapsed Time " + elapsedTime);
        }
    }
}
