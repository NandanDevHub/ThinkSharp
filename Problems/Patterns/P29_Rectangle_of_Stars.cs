namespace ThinkSharp.Problems
{
    class P29_Rectangle_of_Stars
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 29: Rectangle of Stars     ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number of rows: ");
            var inputRows = Console.ReadLine();
            Console.Write("Enter the number of columns: ");
            var inputCols = Console.ReadLine();
            Console.WriteLine();

            if (string.IsNullOrWhiteSpace(inputRows) || !int.TryParse(inputRows, out int rows) || rows <= 0 ||
                string.IsNullOrWhiteSpace(inputCols) || !int.TryParse(inputCols, out int cols) || cols <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive integers for rows and columns.");
                return;
            }

            for(int i=0; i<=rows; i++)
            {
              for (int j = 0; j <=cols; j++)
                {
                    Console.Write("* ");
                } 
               Console.WriteLine();   
            }       
        }
    }
}
