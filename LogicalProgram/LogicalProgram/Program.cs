// See https://aka.ms/new-console-template for more information
namespace Logical_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a problem");
            Console.WriteLine("1 for fibonacci series");
            Console.WriteLine("2 for perfect number");

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Perfect();
                    break;
            }
            
        }
    }
}
