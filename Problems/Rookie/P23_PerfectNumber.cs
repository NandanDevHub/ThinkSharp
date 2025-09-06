namespace ThinkSharp.Problems
{
    // Perfect Number is a positive integer that is equal to the sum of its proper positive divisors, excluding the number itself.
    // For example, 6 is a perfect number because its divisors are 1, 2, and 3, and 1 + 2 + 3 = 6.
    // To check if a number is a perfect number, we can find all its divisors
    // and sum them up, then compare the sum to the original number.
    // Take the number as input from the user.
    // Use a loop to find the divisors and calculate their sum.
    // Finally, check if the sum is equal to the original number.
    // If they are equal, the number is a perfect number; otherwise, it is not.
    // Example Input: 28
    // Example Output: 28 is a perfect number.
    // Explanation: The divisors of 28 are 1, 2, 4, 7, and 14. Their sum is 1 + 2 + 4 + 7 + 14 = 28.

    class PerfectNumber
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 23: Perfect Number       ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the numner to check if it's a Perfect Number: ");
            long input = long.Parse(Console.ReadLine()!);

            long sumOfDivisors = 0;

            for (int i = 1; i * i < input; i++)
            {
                if (input % 2 == 0)
                {
                    sumOfDivisors += i;
                }
            }

            if (input != 0 && sumOfDivisors == input)
            {
                Console.Write($"{input} is a Perfect Number.");
            }
            else
            {
                Console.Write($"{input} is not a Perfect Number.");
            }
        }
    }

}