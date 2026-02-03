using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== LAB 1 MENU ===");
                Console.WriteLine("1. Rectangle Exercise");
                Console.WriteLine("2. Cube Exercise");
                Console.WriteLine("3. Quadratic Equation Exercise");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RectangleExercise.Run();
                        break;
                    case "2":
                        CubeExercise.Run();
                        break;
                    case "3":
                        QuadraticEquationExercise.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
