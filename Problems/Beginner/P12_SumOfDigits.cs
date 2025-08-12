using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ThinkSharp.Problems
{
    class SumOFDigits
    {
        // Take a number as input
        // Use a loop to extract each digit
        // Add the digits together
        // Print the sum
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("     PROBLEM 12: Sum of Digits          ");
            Console.WriteLine("======================================\n");

            Console.Write("Do you want to solve this problem via Recursion (Y/N): ");
            string input = Console.ReadLine()!.ToUpper();
            bool rec = (input == "Y");
            if (rec)
            {
                Console.WriteLine("Solution with Recursion:");
                string splittedDigits = string.Empty;
                int sum = 0;
                Console.Write("Enter a number: ");
                int a = Convert.ToInt16(Console.ReadLine()!);
                SumofDigitsViaRecursion(a, ref splittedDigits, ref sum);

            Console.WriteLine($"The Digits are: {splittedDigits}");
            Console.WriteLine($"The Sum of Digits is: {sum}");
                

            }
            else
            {
                WithOutRecursion();
            }
        }

        private static void WithOutRecursion()
        {
            Console.WriteLine("Solution without Recursion:");
            string splittedDigits = string.Empty;
            int sum = 0;
            Console.Write("Enter a number: ");
            int a = Convert.ToInt16(Console.ReadLine()!);
            while (a > 0)
            {
                int b = a % 10;
                splittedDigits = splittedDigits + b + " ";
                sum += b;
                a /= 10;
            }
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