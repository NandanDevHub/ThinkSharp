namespace ThinkSharp.Programs
{
    // Print Odd Numbers in a Given Range

    class OddNumbers
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("     PROBLEM 7: Odd Numbers in Range    ");
            Console.WriteLine("======================================\n");

            IEnumerable<int> oddNumbers = Enumerable.Range(1, 20).Where(n => n % 2 != 0);
            Console.Write(string.Join(" ", oddNumbers));
        }
    }
}