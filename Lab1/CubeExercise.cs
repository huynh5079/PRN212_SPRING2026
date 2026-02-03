using System;

namespace Lab1
{
    internal class CubeExercise
    {
        public static void Run()
        {
            Console.WriteLine("----- Cube Exercise -----");

            // Input
            Console.Write("Enter side length: ");
            if (!double.TryParse(Console.ReadLine(), out double side) || side < 0)
            {
                Console.WriteLine("Invalid side length. Must be a positive number.");
                return;
            }

            // Calculation
            double volume = Math.Pow(side, 3);

            // Output
            Console.WriteLine($"Volume of the cube: {volume}");
            Console.WriteLine("-------------------------");
        }
    }
}
