using System;

namespace Primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number you want check.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;

            for (int i = 1; i <= number1; i++)
            {
                if (number1 % i == 0)
                {
                    divisors++;
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine("The entered number is a Prime Number");
            }
            else
            {
                Console.WriteLine("The entered number is not a Prime Number");
            }

            Console.ReadLine();

        }
    }
}
