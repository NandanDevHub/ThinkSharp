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
    }
}