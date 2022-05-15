using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int Num, Sum = 0;
            Console.WriteLine("Enter a Number : ");
            Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    Sum = Sum + i;
                }
            }
            if ( Sum == Num)
            {
                Console.WriteLine("The Number is a perfect  number.");
            }
            else
            {
                Console.WriteLine("The Number is not a perfect number.");
            }
        }
    }
}
