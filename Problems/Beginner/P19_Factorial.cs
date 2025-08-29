namespace ThinkSharp.Problems
{
    // Take a factorial number as input
    // Use a loop to multiply the numbers from 1 to that number
    // Print the factorial

    class Factorial
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("     PROBLEM 19: Factorial              ");
            Console.WriteLine("======================================\n");

            Console.WriteLine("Enter the the number to find the Factorial:");
            var number = int.Parse(Console.ReadLine()!);
            var fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine($"Enter factorial of {number} is {fact} ");
        }
    }
}