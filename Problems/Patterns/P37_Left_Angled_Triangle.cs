namespace ThinkSharp.Programs
{
    class P37_Left_Angled_Triangle
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("       PROBLEM 37: Left Angled Triangle  ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            var r = Console.ReadLine();

            if (string.IsNullOrEmpty(r) || !int.TryParse(r, out int rows) || rows <= 0)
            {
                Console.Write("Invalid input. Please enter a valid positive integer for rows.");
                return;
            }

            for( int i = 1; i <= rows; i++)
            {
                for (int j=1;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
