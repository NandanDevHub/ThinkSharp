namespace ThinkSharp.Problems
{
    // This class demonstrates a simple 1D pattern problem.
    // It generates a sequence of numbers based on a specific pattern.
    // The pattern is defined as follows:
    // For a given integer n, the output is a sequence of numbers from 1 to n,
    // where each number is repeated as many times as its value.

    class P27_Pattern_1D
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 27: 1D Pattern Problem     ");
            Console.WriteLine("=========================================\n");

            Console.WriteLine("Enter a positive integer n:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }
            var result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine("Generated Pattern: " + string.Join(", ", result));
        }
    }
}
