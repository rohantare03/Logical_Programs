using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public void PrimeNum()
        {
            int count = 0;
            Console.WriteLine("Enter a number");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    count++;
                    break;

                }


            }
            if (count == 0)
            {
                Console.WriteLine("The number is  a prime number.");
            }
            else
            {
                Console.WriteLine("The number is not a prime number");
            }
        }
    }
}
