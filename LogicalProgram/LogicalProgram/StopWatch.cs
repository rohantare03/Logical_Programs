using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgram
{
    internal class StopWatch
    {
        public void Timer()
        {

            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Hit Enter to start Watch");

            stopWatch.Start();
            Thread.Sleep(6000);
            Console.WriteLine("Hit Enter to stop Watch");

            stopWatch.Stop();
            Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);

        }
    }
}
