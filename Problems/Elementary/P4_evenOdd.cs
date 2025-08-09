namespace ThinkSharp.Problems
{
    /*
        Take the input
        Divide the number by 2
        If the remainder is 0, print "Even"
        Else, print "Odd"
    */

    class EvenOdd
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("   PROBLEM 4: Even or Odd Number Check   ");
            Console.WriteLine("======================================\n");
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine()!);

            if (number % 2 == 0)
            {
                Console.WriteLine($"Number {number} is Even");
            }
            else
            {
                Console.WriteLine($"Number {number} is Odd");
            }
        }
    }
}