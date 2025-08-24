namespace ThinkSharp.Problems
{
    // To find the sum of binary digits of a given binary digits
    // Take the input from the user
    // Add all the digits of the binary number and print the sum
    // For example, if the input is 1011, the output should be 3 (1+0+1+1=3)
    class SumOfBinaryDigits
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("     PROBLEM 15: Sum Of Binary Digits      ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter the first Binary Digit: ");
            string? bin1 = Console.ReadLine();

            Console.Write("Enter the first Binary Digit: ");
            string? bin2 = Console.ReadLine();

            int num1 = Convert.ToInt32(bin1, 2);
            int num2 = Convert.ToInt32(bin2, 2);

            int sumDecimal = num1 + num2;

            string sum = Convert.ToString(sumDecimal, 2);
            Console.WriteLine($"\n The sum of {bin1} and {bin2} is {sum}");
        }
    }
}