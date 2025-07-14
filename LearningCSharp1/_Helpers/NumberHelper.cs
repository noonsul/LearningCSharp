using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp1
{
    public static class NumberHelper
    {
        public static string FizzBuzz(int number)
        {
            /*
            * Create a for loop from 1 to x (15)
            * If divisible by 3 and 5 = FizzBuzz
            * If divisible by 3 = Fizz
            * If divisible by 5 = Buzz
            * else = number
            */

            bool threeDivide = number % 3 == 0;
            bool fiveDivide = number % 5 == 0;

            if (threeDivide && fiveDivide)
            {
                return "FizzBuzz";
            }
            else if (threeDivide)
            {
                return "Fizz";
            }
            else if (fiveDivide)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        public static void FizzBuzz_InputChecker()
        {
            while (true)
            {
                Console.Write("***FizzBuzz***\n Enter a Number you want to play: ");
                string input_FizzBuzz = Console.ReadLine();

                bool isValid_input_FizzBuzz =  = int.TryParse(input_FizzBuzz, out int number_FizzBuzz) && number_FizzBuzz > 0;


                if (isValid_input_FizzBuzz)
                {
                    for (int i = 1; i <= number_FizzBuzz; ++i)
                    {
                        Console.WriteLine(FizzBuzz(i));
                    }
                    Console.WriteLine("***Game Complete!***");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }

        }

        public static string IsPrime (int number)
        {
            /* 
             * Ask Input - One number
             * Check and Validate the Input
             * Check if Prime or NOT
             * Return Prime or Not Prime
             */

            while (true)
            {
                Console.Write("For Prime Number Testing, Enter the Number to Test: ");
                string input_PrimeNumber = Console.ReadLine();

                bool isValid_input_PrimeNumber = int.TryParse(IsPrime(number), out int number_PrimeNumber) && number_PrimeNumber > 0;

                if (isValid_input_PrimeNumber)
                {
                    // Check if the number is prime or not, and return the result
                    bool result_isPrime = false;
                    string postResult_isPrime;

                    if 

                }
                else

            }



        }
    }
}
