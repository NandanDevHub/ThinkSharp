namespace ThinkSharp.Problems
{
    class LargestOfTwoNumbers
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("     PROBLEM 9: Largest of Two Numbers      ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt16(Console.ReadLine()!);
            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt16(Console.ReadLine()!);

            if (firstNumber > secondNumber)
            {
                Console.Write($"{firstNumber} is larger than {secondNumber}");
            }
            else if (firstNumber == secondNumber)
            {
                Console.Write($"{firstNumber} is equal to {secondNumber}");
            }
            else
            {
                Console.Write($"{secondNumber} is larger than {firstNumber}");
            }
        }
    }
}