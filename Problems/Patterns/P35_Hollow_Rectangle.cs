namespace ThinkSharp.Problems
{
    class P35_Hollow_Rectangle
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 35: Hollow Rectangle     ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            var r = Console.ReadLine();

            Console.Write("Enter the number of columns: ");
            var c = Console.ReadLine();

            if (string.IsNullOrEmpty(r) || string.IsNullOrEmpty(c) ||
            !int.TryParse(r, out int rows) || !int.TryParse(c, out int cols) ||
            rows <= 0 || cols <= 0)
            {
                Console.Write("Invalid input. Please enter valid positive integers for rows and columns.");
                return;
            }

            for(int i=1; i<=rows; i++)
            {
                for(int j =1; j<=cols; j++)
                {
                    if (i==1 || i == rows || j == 1 || j == cols)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
