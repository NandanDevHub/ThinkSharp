using System.Data;

namespace ThinkSharp.Problems
{
    class P38_Left_Angled_Triangle_Desc
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("    PROBLEM 38: Left Angled Triangle Desc  ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            int r =  Convert.ToInt32(Console.ReadLine());

            for(int i =1; i<r; i++)
            {
                for (int j = 1; j<r - i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
