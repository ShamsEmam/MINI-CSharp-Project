using System;

namespace ShapeAreaCalculator
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("What shape would you like to find the area of?");
            Console.WriteLine("Please enter 'r' for Rectangle or any other key for Circle:");

            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (ch == 'r')
            {
                Console.WriteLine("Please enter the height of the Rectangle:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the width of the Rectangle:");
                int width = Convert.ToInt32(Console.ReadLine());

                int area = height * width;
                Console.WriteLine($"The area of the rectangle is: {area}");
            }
            else
            {
                Console.WriteLine("Please enter the radius of the Circle:");
                double radius = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * radius * radius;
                Console.WriteLine($"The area of the circle is: {area:F2}");
            }
        }
    }
}
