using System;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n=== LAB 3: COLLECTION AND GENERIC ===");
                Console.WriteLine("1. Generic Calculator");
                Console.WriteLine("2. ArrayList Demo (Product)");
                Console.WriteLine("3. Hashtable Demo (Days)");
                Console.WriteLine("4. Generic Swap");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunGenericCalculator();
                        break;
                    case "2":
                        ArrayListDemo.Run();
                        break;
                    case "3":
                        HashtableDemo.Run();
                        break;
                    case "4":
                        GenericSwap.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void RunGenericCalculator()
        {
            Console.WriteLine("----- Question 1: Generic Calculator -----");
            
            // Test with Integer
            var intCalc = new GenericCalculator<int>();
            Console.WriteLine($"Add(10, 5) = {intCalc.Add(10, 5)}");
            Console.WriteLine($"Subtract(10, 5) = {intCalc.Subtract(10, 5)}");
            Console.WriteLine($"Multiply(10, 5) = {intCalc.Multiply(10, 5)}");
            Console.WriteLine($"Divide(10, 5) = {intCalc.Divide(10, 5)}");

            Console.WriteLine();

            // Test with Double
            var doubleCalc = new GenericCalculator<double>();
            Console.WriteLine($"Add(5.5, 2.0) = {doubleCalc.Add(5.5, 2.0)}");
            Console.WriteLine($"Subtract(5.5, 2.0) = {doubleCalc.Subtract(5.5, 2.0)}");
            Console.WriteLine($"Multiply(5.5, 2.0) = {doubleCalc.Multiply(5.5, 2.0)}");
            Console.WriteLine($"Divide(5.5, 2.0) = {doubleCalc.Divide(5.5, 2.0)}");

            Console.WriteLine("------------------------------------------");
        }
    }
}
