namespace ThinkSharp.Problems
{
    class SwapTwoNumbers
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("      PROBLEM 10: Swap Two Numbers          ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter First Number: ");
            int a = Convert.ToInt16(Console.ReadLine()!);
            Console.Write("Enter Second Number: ");
            int b = Convert.ToInt16(Console.ReadLine()!);

            var temp = a;
            a = b;
            b = temp;

            Console.Write($"Swapped Values: First Number is now {a} and Second Number is {b}");
        }
            
    }
}