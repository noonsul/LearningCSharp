using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCSharp1
{
    public static class NumberHelper
    {
        const string message_loading = "...processing";


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

                bool isValid_input_FizzBuzz = int.TryParse(input_FizzBuzz, out int number_FizzBuzz) && number_FizzBuzz > 0;


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

        public static void IsPrime_InputChecker ()
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

                bool isValid_input_PrimeNumber = int.TryParse(input_PrimeNumber, out int number_PrimeNumber) && number_PrimeNumber > 1;

                if (isValid_input_PrimeNumber)
                {
                    for (int i = 0; i < message_loading.Length; i++)
                    {
                        Console.Write(message_loading[i]);
                        Thread.Sleep(250);

                    }
                    Console.WriteLine();
                    
                    // Call the Is Prime Method here.
                    IsPrime(number_PrimeNumber);
                    break;
                }
              
                else
                {
                    Console.WriteLine("Please enter a vaild number.");
                }

            }
        }

        public static bool IsPrime (int numberToTest_IsPrime)
        {
            // Check if the number is prime or not, and return the result
            double sqrt_value = Math.Sqrt(Convert.ToDouble(numberToTest_IsPrime));
            int sqrt_value_int = Convert.ToInt32(sqrt_value);
            //Console.WriteLine($"sqrt_value: {sqrt_value_int.ToString()}");//debugging only
            Console.WriteLine();
            bool isPrimeNumber = true;

            //Issue#1: Skip checking even numbers
            if (numberToTest_IsPrime % 2 != 0)
            {
                isPrimeNumber = false;
            }
            else
            {
                for (int i = 2; i <= sqrt_value_int; i++)
                {
                    //Console.WriteLine($"i: {i}");//debugging only

                    int remainder = numberToTest_IsPrime % i;
                    //Console.WriteLine($"{numberToTest_IsPrime} % {i} = {remainder}");//debugging only
                    if (remainder == 0)
                    {
                        isPrimeNumber = false;

                    }

                }
            }            

            if (isPrimeNumber)
            {
                string postResult_isPrime = $"{numberToTest_IsPrime} is a Prime Number.";
                Console.WriteLine(postResult_isPrime);
                return true;
            }
            else
            {
                string postResult_isPrime = $"{numberToTest_IsPrime} is NOT a Prime Number.";
                Console.WriteLine(postResult_isPrime);
                return false;
            }
        }
    }
}
