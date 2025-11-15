using System.Runtime.CompilerServices;

namespace ThinkSharp.Problems
{
    class P28_What1DPattern
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 28: What 1D Pattern?      ");
            Console.WriteLine("=========================================\n");

            Console.WriteLine("What Symbol you want to Print in 1D: ");
            var input = Console.ReadLine();

            Console.WriteLine("How many Times do you want to print it?: ");
            int countNos = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < countNos; i++)
            {
                Console.Write(input);
            }
        }
    }
}
