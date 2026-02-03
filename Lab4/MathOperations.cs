using System;

namespace Lab4
{
    public delegate void SampleDelegate(int a, int b);

    public class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Result: {0}", x - y);
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply Result: {0}", x * y);
        }

        public void Divide(int x, int y)
        {
             if (y != 0)
                Console.WriteLine("Divide Result: {0}", x / y);
             else
                Console.WriteLine("Divide Result: Cannot divide by zero");
        }
    }
}
