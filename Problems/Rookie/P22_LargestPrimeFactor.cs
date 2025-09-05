namespace ThinkSharp.Problems
{
    // To find the largest prime factor of a given number
    // A prime factor is a factor that is a prime number
    // Take the number as input from the user
    // Use a loop to find the prime factors and keep track of the largest one
    // Finally, print the largest prime factor
    // Example Input: 13195
    // Example Output: The largest prime factor of 13195 is 29.
    // Explanation: The prime factors of 13195 are 5, 7,
    // 13, and 29. Among these, 29 is the largest.

    class LargestPrimeFactor
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("     PROBLEM 22: Largest Prime Factor      ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the Number to find out Largest Prime Factorial: ");
            long n = long.Parse(Console.ReadLine()!);
            long number = n;
            long largestPrime = -1;

            while (number % 2 == 0)
            {
                largestPrime = 2;
                number /= 2;
            }

            for (int i = 3; i * i < number; i += 2)
            {
                while (number % i == 0)
                {
                    largestPrime = i;
                    number /= i;
                }
            }

            if (number > 1)
            {
                largestPrime = number;
            }

            Console.Write($"The Largest Prime Factorial of {n} is {number}");
        }
    }
}