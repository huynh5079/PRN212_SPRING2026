using System;

namespace Lab1
{
    internal class RectangleExercise
    {
        public static void Run()
        {
            Console.WriteLine("----- Rectangle Exercise -----");
            
            // Input
            Console.Write("Enter length: ");
            if (!double.TryParse(Console.ReadLine(), out double length) || length < 0)
            {
                Console.WriteLine("Invalid length. Must be a positive number.");
                return;
            }

            Console.Write("Enter width: ");
            if (!double.TryParse(Console.ReadLine(), out double width) || width < 0)
            {
                Console.WriteLine("Invalid width. Must be a positive number.");
                return;
            }

            // Calculations
            double perimeter = (length + width) * 2;
            double area = length * width;
            double smallerSide = Math.Min(length, width);

            // Output
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Smaller Side: {smallerSide}");
            Console.WriteLine("------------------------------");
        }
    }
}
