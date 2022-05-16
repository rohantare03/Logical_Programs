// See https://aka.ms/new-console-template for more information
namespace LogicalProgram 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a problem");
            Console.WriteLine("1 for fibonacci series");
            Console.WriteLine("2 for perfect number");
            Console.WriteLine("3 for prime number");
            Console.WriteLine("4 for reverse number");

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
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.PrimeNum();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.ReverseNum();
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    break; 
            }
            
        }
    }
}
