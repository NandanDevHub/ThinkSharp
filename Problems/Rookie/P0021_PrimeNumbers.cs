namespace ThinkSharp.Problems
{
    // To print all prime numbers up to a specified limit
    // Prime number is a number that is divisible only by 1 and itself
    // Take the limit as input from the user
    // Use nested loops to check for prime numbers
    // Print the prime numbers

    class PrimeNumbers
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("      PROBLEM 21: Prime Numbers         ");
            Console.WriteLine("======================================\n");

            Console.Write("Enter the limit to print all the prime numbers: ");
            var input = int.Parse(Console.ReadLine()!);
            string primeNumbers = string.Empty;

            if (input < 2)
            {
                Console.WriteLine("No Prime Numbers in entered range");
            }

            else
            {
                for (int i = 2; i <= input; i++)
                {
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % 2 != 0)
                        {
                            primeNumbers += ", ";
                            break;
                        }
                    }
                }

                Console.WriteLine($"The Prime Numbers uptill {input} are : {primeNumbers}");
            }
        }
    }
}