namespace ThinkSharp.Problems
{
    class P33_Alternating_Rows
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 33: Alternating Rows     ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            var rows = Console.ReadLine();

            Console.Write("Enter the number of columns: ");
            var columns = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(rows) || string.IsNullOrWhiteSpace(columns) ||
             !int.TryParse(rows, out int r) || !int.TryParse(columns, out int c) ||
             r <= 0 || c <= 0)
            {
                Console.WriteLine("Invalid input. Please enter valid integers for rows and columns.");
                return;
            }
            Console.WriteLine();
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j<= c; j++)
                {
                    if (i%2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
            Console.WriteLine();
            }
        }
    }
}
