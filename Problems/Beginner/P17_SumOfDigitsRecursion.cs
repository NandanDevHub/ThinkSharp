using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ThinkSharp.Problems
{
    class SumOFDigitsRecursion
    {
        // Take a number as input
        // The base case is when the number is 0, return 0
        // For other cases, return the sum of the last digit (number % 10) and
        // the result of the function called with the number divided by 10 (number / 10)
        // This effectively breaks down the number digit by digit, summing them up recursively
        // Print the digits and the sum
        public static void Run()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine("    PROBLEM 17: Sum of Digits using Recursion   ");
            Console.WriteLine("==============================================\n");

            string splittedDigits = string.Empty;
            int sum = 0;
            Console.Write("Enter a number: ");
            int a = Convert.ToInt16(Console.ReadLine()!);
            SumofDigitsViaRecursion(a, ref splittedDigits, ref sum);

            Console.WriteLine($"The Digits are: {splittedDigits}");
            Console.WriteLine($"The Sum of Digits is: {sum}");
        }

        private static void SumofDigitsViaRecursion(int number, ref string digits, ref int sum)
        {
            if (number == 0)
            {
                return;
            }

            SumofDigitsViaRecursion(number / 10, ref digits, ref sum);
            int lastDigit = number % 10;
            digits += lastDigit + " ";
            sum += lastDigit;
        }
    }
}