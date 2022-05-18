using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CouponNumber
    {
        public string Generator()
        {
            string Code = "";
            Code = Convert.ToString(new Random().Next(0, 20));
            return Code;

        }
        public CouponNumber() 
        {
            Console.Write("Enter the number of unique coupons request:");

            int N = Convert.ToInt32(Console.ReadLine());
            string[] Coupon_List = new string[N];
            string Coupon_Code = Generator();

            for (int i = 0; i < N; i++)
            {
                while (Array.Exists(Coupon_List, element => element == Coupon_Code))
                {
                    Coupon_Code = Generator();
                }
                Coupon_List[1] = Coupon_Code;
            }
            Console.WriteLine("The required Coupon Number are,");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(Coupon_List[i]);
            }


        }
    }
}
