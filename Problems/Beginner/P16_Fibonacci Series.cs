using System.Text;

namespace ThinkSharp.Problems
{
    // To show the Fibonacci Series up to n terms
    // Take the nterms from the user
    // add the previous two terms to get the next term

    class FibonacciSeries
    {
        public static void Run()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("     PROBLEM 16: Fibonacci Series          ");
            Console.WriteLine("==========================================\n");

            Console.Write("Enter the number of terms for Fibonacci Series: ");
            int nterms = Convert.ToInt32(Console.ReadLine()!);

            int firstTerm = 0, secondTerm = 1, nextTerm;
            string series = string.Empty;

            for (int i = 1; i <= nterms; ++i)
            {
                series = series + firstTerm + ", ";
                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
            Console.WriteLine($"The Fibonacci Series up to {nterms} terms is:{series.TrimEnd(',', ' ')}");
        }
    }
}