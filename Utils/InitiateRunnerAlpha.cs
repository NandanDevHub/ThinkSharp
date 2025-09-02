using ThinkSharp.Problems;
using ThinkSharp.Programs;

namespace ThinkSharp.Utils
{
    public static class InitiateRunnerAlpha
    {
        public static void RunProblems(int pID)
        {
            switch (pID)
            {
                case 1:
                    HelloWorld.Run();
                    break;
                case 2:
                    Printname.Run();
                    break;
                case 3:
                    Addition.Run();
                    break;
                case 4:
                    EvenOdd.Run();
                    break;
                case 5:
                    ForLoop.Run();
                    break;
                case 6:
                    AreaOfShapes.Run();
                    break;
                case 7:
                    OddNumbers.Run();
                    break;
                case 8:
                    PositiveNegative.Run();
                    break;
                case 9:
                    LargestOfTwoNumbers.Run();
                    break;
                case 10:
                    SwapTwoNumbers.Run();
                    break;
                case 11:
                    MultiplesOf3And5.Run();
                    break;
                case 12:
                    SumOFDigits.Run();
                    break;
                case 13:
                    ReverseInteger.Run();
                    break;
                case 14:
                    PalindromeInteger.Run();
                    break;
                case 15:
                    SumOfBinaryDigits.Run();
                    break;
                case 16:
                    FibonacciSeries.Run();
                    break;
                case 17:
                    SumOFDigitsRecursion.Run();
                    break;
                case 18:
                    FibonacciRecursion.Run();
                    break;
                case 19:
                    Factorial.Run();
                    break;
                case 20:
                    FactorialRecursion.Run();
                    break;
                case 21:
                    PrimeNumbers.Run();
                    break;
                default:
                    Console.WriteLine("Problem Number is currently not available.");
                    break;
            }
        }
    }
}