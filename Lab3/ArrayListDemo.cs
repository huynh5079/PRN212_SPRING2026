using System;
using System.Collections;

namespace Lab3
{
    public class ArrayListDemo
    {
        public static void Run()
        {
            Console.WriteLine("----- Question 2: ArrayList Demo -----");
            ArrayList productList = new ArrayList();

            // Create and add 5 products
            productList.Add(new Product("Laptop", 1500.00, 10));
            productList.Add(new Product("Mouse", 25.50, 50));
            productList.Add(new Product("Keyboard", 75.00, 30));
            productList.Add(new Product("Monitor", 300.25, 15));
            productList.Add(new Product("Headset", 50.00, 20));

            Console.WriteLine("Displaying Products in ArrayList:");
            foreach (var item in productList)
            {
                // Implicitly calls ToString()
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
