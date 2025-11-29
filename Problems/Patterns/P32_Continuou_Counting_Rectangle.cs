namespace ThinkSharp.Problems
{
    class P32_Continuous_Counting_Rectangle
    {
        public static void Run()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine("    PROBLEM 32: Continuous Counting Rectangle   ");
            Console.WriteLine("==============================================\n");

            Console.Write("Enter the number of rows: ");
            var rows = Console.ReadLine();

            Console.Write("Enter the number of columns: ");
            var columns = Console.ReadLine();

            if (!int.TryParse(rows, out int r) || !int.TryParse(columns, out int c))
            {
                Console.WriteLine("Invalid input. Please enter valid integers for rows and columns.");
                return;
            }

            int a = 1;
            for(int i = 1; i<=r; i++)
            {
                for(int j = 1; j <= c; j++)
                {
                   Console.Write(a);
                   a++;
                }
                Console.WriteLine();
            }
        }
    }
}
