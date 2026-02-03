using System;

namespace Lab3
{
    public class GenericSwap
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Run()
        {
            Console.WriteLine("----- Question 4: Generic Swap -----");
            
            // Swap Integers
            int input1 = 10, input2 = 20;
            Console.WriteLine($"Before Swap (int): a = {input1}, b = {input2}");
            Swap(ref input1, ref input2);
            Console.WriteLine($"After Swap (int):  a = {input1}, b = {input2}");

            // Swap Strings
            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"\nBefore Swap (string): a = {str1}, b = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"After Swap (string):  a = {str1}, b = {str2}");

            Console.WriteLine("------------------------------------");
        }
    }
}
