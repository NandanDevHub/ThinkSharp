namespace ThinkSharp.Programs
{
    // To Check wheather the number is positive or negative
    // Take the inuput from the user
    // If the number is greater than 0 then it is positive
    // If the number is less than 0 then it is negative

    class PositiveNegative
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("    PROBLEM 8: Positive or Negative Number  ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number > 0)
            {
                Console.WriteLine($"{number} is a Positive Number.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is ZERO");
            }
            else
            {
                Console.WriteLine($"{number} is a Negative Number.");
            }
        }
    }
}