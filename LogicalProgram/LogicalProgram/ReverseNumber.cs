using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public void ReverseNum()
        {
            int Num, reverse = 0;
            Console.WriteLine("Enter the number : ");
            Num = Convert.ToInt32(Console.ReadLine());

            while(Num > 0)
            {
                reverse = reverse * 10 + Num%10;
                Num = Num / 10;
            }
            Console.WriteLine("Reversed Number is : " + reverse);
        }
    }
}
