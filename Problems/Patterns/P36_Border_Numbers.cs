using System.Runtime.InteropServices;

namespace ThinkSharp.Problems
{
    class P36_Border_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("         PROBLEM 36: Border Numbers      ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            var r = Console.ReadLine();

            Console.Write("Enter the number of columns: ");
            var c = Console.ReadLine();

            if (string.IsNullOrEmpty(r) || string.IsNullOrEmpty(c) || !int.TryParse(r, out int rows) || !int.TryParse(c, out int cols))
            {
                Console.Write("Invalid input. Please enter valid integers for rows and columns.");
                return;
            }

            for (int i = 1; i<=rows; i++)
            {
                for (int j = 1; j<=cols; j++)
                {
                    if(i == 1 || i == rows)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        if(j == 1)
                        {
                            Console.Write(1);
                        }
                        else if(j == cols)
                        {
                            Console.Write(cols);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
