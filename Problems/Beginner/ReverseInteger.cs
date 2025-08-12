namespace ThinkSharp.Problems
{
    class ReverseInteger
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("     PROBLEM 13: Reverse A Integer          ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter a number: ");
            int num = Convert.ToInt16(Console.ReadLine()!);
            var n = num;
            int rev = 0;

            while (num != 0)
            {
                var a = num % 10;
                rev = rev * 10 + a;
                num /= 10;
            }

            Console.WriteLine($"The reverse of number {n} is: {rev}"); 
        }
    }
}