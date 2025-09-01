namespace ThinkSharp.Problems
{
    // Take the factorial number as input
    // The base case is when the number is 0, return 1
    // For other cases, return the product of the number and
    // the result of the function called with the number decremented by 1 (number - 1)
    // This effectively breaks down the factorial calculation into smaller subproblems
    // Print the factorial

    class FactorialRecursion
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("     PROBLEM 20: Factorial Recursion    ");
            Console.WriteLine("======================================\n");

            Console.Write("Enter the number to find the Factorial (Recursion): ");
            var input = int.Parse(Console.ReadLine()!);

            var factorialRecursion = Factorial(input);
            Console.WriteLine($"The Factorial of {input} is {factorialRecursion}");
        }

        private static long Factorial(int n)
        {
            if (n is 0 or 1)
            {
                return 1;
            }
            else
            {
                var fact = n * (Factorial(n - 1));
                return fact;
            }
        }
    }
}