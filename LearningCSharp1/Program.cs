using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp1._Helpers;

namespace LearningCSharp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (true)
            {
                Console.WriteLine("Hello! What would you like to Test?");
                Console.WriteLine("1 - FizzBuzz");
                Console.WriteLine("2 - Is Prime?");
                Console.WriteLine("3 - Password Checker");
                Console.WriteLine("0 - Exit the program");

                string input = Console.ReadLine();

                if (int.TryParse(input, out choice)) //If successfully converted the string input to choice number (int)
                {
                    // Check the Choice number to see if any of the given options is chosen.
                    if (choice == 1 || choice == 2 || choice == 3)
                    {
                        break; // If so, exit the user prompt loop
                    }
                    else
                    {
                        Console.WriteLine("We don't have that option at this time. Please choose from the given options only.");
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input. Please choose from the given options only.");
                }
            }

            // After the Loop Exit, call the applicable method per choice
            if (choice == 1) // Choice 1 is for FizzBuzz
            {
                // Call FizzBuzz Input Checker
                NumberHelper.FizzBuzz_InputChecker();
            }
            else if (choice == 2)
            {
                // Call Is Prime Input Checker
                NumberHelper.IsPrime_InputChecker();
            }
            else if (choice == 3)
            {
                // Call Password Checker
                SecurityHelper.PasswordChecker();
            }

            Console.ReadLine();
        }

    }
}
