namespace ThinkSharp.Problems
{
    /* 
    Take a number as input
    The base case is when the number is 0, return 0
    For other cases, return the sum of the last digit (number % 10) and
    the result of the function called with the number divided by 10 (number / 10)
    This effectively breaks down the number digit by digit, summing them up recursively
    Print the digits and the sum
    */

    class FibonacciRecursion
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("     PROBLEM 18: Fibonacci Recursion    ");
            Console.WriteLine("======================================\n");

            Console.Write("Enter the number of terms for Fibonacci Series (Recursion): ");
            int nterms = Convert.ToInt32(Console.ReadLine()!);

            string series = string.Empty;
            for (int i = 0; i < nterms; i++)
            {
                series = series + Fibonacci(i) + ", ";
            }
            Console.WriteLine($"The Fibonacci Series using Recursion up to {nterms} terms is:{series.TrimEnd(',', ' ')}");
        }

        private static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}