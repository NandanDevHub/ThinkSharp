namespace ThinkSharp.Programs
{
    // To Add two numbers and print the result.

    class Addition
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine()!);

            int sum = firstNumber + secondNumber;
            Console.WriteLine("The Sum is " + sum);
        }
    }
}