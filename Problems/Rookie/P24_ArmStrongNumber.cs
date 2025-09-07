namespace ThinkSharp.Problems
{
    // An Armstrong number (or narcissistic number) is a number that is equal to the sum of its own digits each raised to the power of the number of digits.
    // For example, 153 is an Armstrong number because 1^3 + 5^3 + 3^3 = 153.
    // To check if a number is an Armstrong number, we can extract each digit,
    // raise it to the power of the total number of digits, and sum these values.
    // Take the number as input from the user.
    // Use a loop to extract each digit, raise it to the power of the number of digits, and calculate the sum.
    // Finally, compare the sum to the original number.
    // If they are equal, the number is an Armstrong number; otherwise, it is not
    // Example Input: 9474
    // Example Output: 9474 is an Armstrong number.
    // Explanation: The digits of 9474 are 9, 4, 7 and 4. 9^4 + 4^4 + 7^4 + 4^4 = 9474.
    // Since the sum equals the original number, 9474 is an Armstrong number.
    class ArmStrongNumber
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 24: ArmStrong Number      ");
            Console.WriteLine("=========================================\n");

            Console.Write("Enter the number to check if it's an Armstrong Number: ");
            long input = long.Parse(Console.ReadLine()!);

            int totalDigits = 0;
            long sum = 0;
            long originalInput = input;
            long temp = input;

            while (temp > 1)
            {
                totalDigits++;
                temp /= 10;
            }

            temp = input;

            while (temp > 0)
            {
                long currentDigit = temp % 10;
                sum += (long)(Math.Pow(currentDigit, totalDigits));
                temp /= 10;
            }

            if (sum == originalInput)
            {
                Console.Write($"{originalInput} is an Armstrong Number.");
            }
            else
            {
                Console.Write($"{originalInput} is not an Armstrong Number.");
            }
        }


    }
}