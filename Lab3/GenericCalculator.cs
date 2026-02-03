using System;

namespace Lab3
{
    public class GenericCalculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }

        public T Subtract(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }

        public T Multiply(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 * d2;
        }

        public T Divide(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            if (d2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return d1 / d2;
        }
    }
}
