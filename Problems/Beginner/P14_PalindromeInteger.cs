using ThinkSharp.Problems;

namespace ThinkSharp.Problems
{
    // To Check whether the number is a Palindrome Integer
    // Take the input from the user
    // If the number is equal to its reverse then it is a Palindrome Integer

    class PalindromeInteger
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("     PROBLEM 14: Palindrome Integer         ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter the Integer to check for Palindrome: ");
            int num = Convert.ToInt32(Console.ReadLine()!);

            var originalNum = num;
            var rev = 0;
            while (num != 0)
            {
                var a = num % 10;
                rev = rev * 10 + a;
                num /= 10;
            }

            if (originalNum == rev)
            {
                Console.WriteLine("The Number " + originalNum + " is Palindorme");
            }
            else
            {
                Console.WriteLine("The Number " + originalNum + " is NOT Palindrome");
            }
        }
    }
 }
