using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please press enter to start");
            string str = Console.ReadLine();

            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Welcome to the Factorial Calculator");

                Console.WriteLine("Enter an integer that's greater than 0 but less thann 10 : ");

                int numberInt = int.Parse(Console.ReadLine());

                if (numberInt >=0 && numberInt <= 10)
                {
                    int result = numberInt;

                    for (int i = 1; i < numberInt; i++)
                    {
                        result = result * i;
                    }
                    Console.WriteLine("the Factorial number is " + result);

                }
                Console.WriteLine("would you like to continue (y/n) ?");

                string input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
