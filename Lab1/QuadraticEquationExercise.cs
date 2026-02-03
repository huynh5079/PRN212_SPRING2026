using System;

namespace Lab1
{
    internal class QuadraticEquationExercise
    {
        public static void Run()
        {
            Console.WriteLine("----- Quadratic Equation Exercise -----");
            Console.WriteLine("Equation format: ax^2 + bx + c = 0");

            // Input
            Console.Write("Enter a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid input for a.");
                return;
            }

            Console.Write("Enter b: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid input for b.");
                return;
            }

            Console.Write("Enter c: ");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Invalid input for c.");
                return;
            }

            // Calculations
            double delta = Math.Pow(b, 2) - 4 * a * c;

            // Output
            Console.WriteLine($"Delta: {delta}");
            if (delta >= 0)
            {
                double sqrtDelta = Math.Sqrt(delta);
                Console.WriteLine($"Square root of Delta: {sqrtDelta}");
            }
            else
            {
                Console.WriteLine("Delta is negative, cannot calculate real square root.");
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
