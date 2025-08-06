using ThinkSharp.Problems;
using ThinkSharp.Programs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter the Problem Number:");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                HelloWorld.Run();
                break;
            case "2":
                Printname.Run();
                break;
            case "3":
                Addition.Run();
                break;
            case "4":
                EvenOdd.Run();
                break;
            case "5":
                ForLoop.Run();
                break;
            default:
                Console.WriteLine("Problem not found.");
                return;
        }
    }
}