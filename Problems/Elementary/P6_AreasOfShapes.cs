using System.Reflection.Metadata;

namespace ThinkSharp.Programs
{
    // Program to Calculate the area of different shapes
    class AreaOfShapes
    {
        public static void Run()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("      PROBLEM 6: Areas of 2D Shapes      ");
            Console.WriteLine("======================================\n");

            float area;
            const float half = 0.5f;
            Console.Write("Enter the valid shape: ");
            string shapeType = Console.ReadLine()!;
            switch (shapeType.ToUpper())
            {
                case "SQUARE":
                    Console.Write("Enter the Square Side: ");
                    int side = int.Parse(Console.ReadLine()!);

                    area = side * side;
                    Console.WriteLine($"Area of Square is {area}");
                    break;
                case "RECTANGLE":
                    Console.Write("Enter the Length of Rectangle: ");
                    float length = float.Parse(Console.ReadLine()!);
                    Console.Write("Enter the Breadth of Rectangle: ");
                    float breadth = float.Parse(Console.ReadLine()!);

                    area = length * breadth;
                    Console.Write($"Area of Rectangle is {area}");
                    break;
                case "TRIANGLE":
                    Console.Write("Enter the Base of Triangle: ");
                    float baseofTriangle = float.Parse(Console.ReadLine()!);
                    Console.Write("Enter the Height of Triangle: ");
                    float heightofTriangle = float.Parse(Console.ReadLine()!);

                    area = half * (baseofTriangle * heightofTriangle);
                    Console.Write($"Area of Triangle is {area}");
                    break;
                case "CIRCLE":
                    Console.Write("Enter the Radius of Circle: ");
                    float radius = float.Parse(Console.ReadLine()!);

                    const double piValue = Math.PI;
                    float pi = Convert.ToSingle(piValue); 

                    area = pi * (radius * radius);
                    Console.Write($"Area of Circle {area}");
                    break;
            }
            
        }
    }
    
}