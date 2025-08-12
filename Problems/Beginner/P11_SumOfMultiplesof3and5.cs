namespace ThinkSharp.Problems
{
    class MultiplesOf3And5
    {
        // Use a for loop to find the sum of all multiples of 3 and 5 below 100
        // Divide each number by 3 and 5
        // If the remainder is 0, then it is a multiple of 3 or 5
        // Add the number to the sum
        // Print the sum
        public static void Run()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine("  PROBLEM 11: Sum of All Multiples of 3 and 5   ");
            Console.WriteLine("==============================================\n");

            int a, b, Sum = 0;
            string multiples = string.Empty;

            for (int i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;

                if (a == 0 && b == 0)
                {
                    multiples = multiples + i + " ";
                    Sum += i;
                }
            }
            Console.Write($"The Multiples of 3 and 5 are: {multiples} \n");
            Console.Write($"The Sum iof Multiples of 3 and 5 is {Sum}");
        }
    }

}