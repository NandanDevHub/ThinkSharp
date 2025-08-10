using ThinkSharp.Problems;
using ThinkSharp.Programs;

namespace ThinkSharp.Utils
{
    public static class ProblemSet1Runner
    {
        public static void RunProblemsSet1(int pID)
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
                default:
                    Console.WriteLine("Problem Number is currently not available.");
                    break;
            }
        }
    }
}