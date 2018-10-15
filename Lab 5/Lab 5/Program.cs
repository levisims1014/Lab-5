using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string user;
            do
            {
                int fact;
                long x = 1;
                Console.WriteLine("Welcome to the Factorial Calculator!");
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");

                fact = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= fact; i++)
                {
                    x = x * i;
                    {
                        Console.WriteLine("Your Factorial = ");
                        Console.WriteLine(x);
                    }
                }
                Console.WriteLine("Continue? y/n");
                user = Console.ReadLine().ToLower();
            }
            while
            (user == "y" || user == "yes");
            Console.WriteLine("Goodbye!");
        }
    }
}
