using ThinkSharp.Problems;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter the Problem Number:");
        var input = Console.ReadLine();

        switch (input)
        {
            case "00":
                HelloWorld.Run();
                break;
            default:
                Console.WriteLine("Problem not found.");
                return;
        }
    }
}