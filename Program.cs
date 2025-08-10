using ThinkSharp.Utils;

Console.Write("\nPlease Enter the Problem Number: ");
try
{
    var input = int.Parse(Console.ReadLine()!);
    var group = (input - 1) / 250 + 1;
    switch (group)
    {
        case 1:
            ProblemSet1Runner.RunProblemsSet1(input);
            break;
        default:
            Console.WriteLine("Problem not found.");
            break;
    }
    Console.WriteLine("\n");
    return;
}
catch
{
    Console.WriteLine("Please enter a valid number and try again.");
    return;
}
