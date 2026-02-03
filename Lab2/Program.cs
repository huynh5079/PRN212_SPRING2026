using System;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 2. Viết chương trình tạo ra 2 sản phẩm có thông tin nhập từ bàn phím
            Console.WriteLine("=== NHẬP THÔNG TIN 2 SẢN PHẨM (YÊU CẦU 2) ===");
            Product pd1 = new Product();
            Product pd2 = new Product();

            Console.WriteLine("--- Sản phẩm 1 ---");
            pd1.input();
            
            Console.WriteLine("\n--- Sản phẩm 2 ---");
            pd2.input();

            Console.WriteLine("\n=== HIỂN THỊ THÔNG TIN (YÊU CẦU 2) ===");
            pd1.display();
            pd2.display();

            // 3. Viết chương trình tạo 2 sản phẩm (có giảm giá và không giảm giá) bằng constructor
            Console.WriteLine("\n=== TEST CONSTRUCTORS (YÊU CẦU 3) ===");
            
            // Sản phẩm có giảm giá
            Product pd3 = new Product("Laptop Gaming", 25000000, 2000000);
            
            // Sản phẩm không có giảm giá (ngầm định discount = 0)
            Product pd4 = new Product("Chuột Logitech", 500000);

            Console.WriteLine("--- Sản phẩm 3 (Constructor 3 tham số) ---");
            pd3.display();

            Console.WriteLine("--- Sản phẩm 4 (Constructor 2 tham số) ---");
            pd4.display();

            Console.ReadKey();
        }
    }
}
