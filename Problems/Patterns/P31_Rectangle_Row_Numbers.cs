using System.Globalization;

namespace ThinkSharp.Problems
{
    class P31_Rectangle_Row_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 31: Rectangle Row Numbers   ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            var rows = Console.ReadLine();

            Console.Write("Enter the number of columns: ");
            var columns = Console.ReadLine();

            if (!int.TryParse(rows, out int r) || !int.TryParse(columns, out int c))
            {
                Console.WriteLine("Invalid input. Please enter valid integers for rows and columns.");
                return;
            }

            for (int i=1; i<r; i++)
            {
                for (int j = 1; j<c; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
