using System.Globalization;

namespace ThinkSharp.Programs
{
    // Take the input
    // use a for loop to print numbers from 1 to n
    // where n is the input number

    class ForLoop
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("      PROBLEM 5: For Loop Example       ");
            Console.WriteLine("======================================\n");
            Console.Write("Enter the number of times to print: ");
            var num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Looped {i} Time(s)");
            }
        }
    }
}