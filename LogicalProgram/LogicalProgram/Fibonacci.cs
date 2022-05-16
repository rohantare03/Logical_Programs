using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram 
{
    internal class Fibonacci
    {
        public void FibSeries()
        {
            int num1 = 0, num2 = 1, num3, n = 10;
            

            Console.WriteLine("Fibonacci series is ");
            Console.Write(num1 + " " + num2 + " ");

            for (int i = 2; i < n; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
