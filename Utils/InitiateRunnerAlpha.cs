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
                case 22:
                    LargestPrimeFactor.Run();
                    break;
                case 23:
                    PerfectNumber.Run();
                    break;
                case 24:
                    ArmStrongNumber.Run();
                    break;
                case 25:
                    InsertionSort.Run();
                    break;
                case 26:
                    SelectionSort.Run();
                    break;
                case 27:
                    P27_Pattern_1D.Run();
                    break;
                case 28:
                    P28_What1DPattern.Run();
                    break;
                case 29:
                    P29_Rectangle_of_Stars.Run();
                    break;
                case 30:
                    P30_Rectangle_of_Numbers.Run();
                    break;
                case 31:
                    P31_Rectangle_Row_Numbers.Run();
                    break;
                case 32:
                    P32_Continuous_Counting_Rectangle.Run();
                    break;
                case 33:
                    P33_Alternating_Rows.Run();
                    break;
                case 34:
                    P34_Alternating_Columns.Run();
                    break;
                case 35:
                    P35_Hollow_Rectangle.Run();
                    break;
                case 36:
                    P36_Border_Numbers.Run();
                    break;
                case 37:
                    P37_Left_Angled_Triangle.Run();
                    break;
                case 38:
                    P38_Left_Angled_Triangle_Desc.Run();
                    break;
                default:
                    Console.WriteLine("Problem Number is currently not available.");
                    break;
            }
        }
    }
}
