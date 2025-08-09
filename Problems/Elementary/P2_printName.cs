namespace ThinkSharp.Problems
{
    // A simple program to take input your name and print it to console.

    class Printname
    {
        public static void Run()
        {
            Console.WriteLine("\n============================================");
            Console.WriteLine("     PROBLEM 2: Read and Print Your Name      ");
            Console.WriteLine("============================================\n");
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Hello, {name}!");
        }
    }
}