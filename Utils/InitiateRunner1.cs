using ThinkSharp.Problems;
using ThinkSharp.Programs;

namespace ThinkSharp.Utils
{
    public static class InitiateRunner1
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
                default:
                    Console.WriteLine("Problem Number is currently not available.");
                    break;
            }
        }
    }
}