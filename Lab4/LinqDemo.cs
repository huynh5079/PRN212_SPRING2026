using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class LinqDemo
    {
        public static void Run()
        {
            Console.WriteLine("----- Question 3: LINQ Demo -----");

            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"}, 2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"}, 1),
                new Product(3, "Đèn chùm",   500, new string[] {"Trắng"}, 3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"}, 1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"}, 2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"}, 2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"}, 3),
            };

            // a. Filter products with price of 400
            Console.WriteLine("\n--- a. Products with Price = 400 ---");
            var price400 = products.Where(p => p.Price == 400);
            foreach (var item in price400) Console.WriteLine(item);

            // b. Filter products containing color "Yellow" (Vàng)
            Console.WriteLine("\n--- b. Products with Color 'Vàng' ---");
            var yellowProducts = products.Where(p => p.Colors.Contains("Vàng"));
            foreach (var item in yellowProducts) Console.WriteLine(item);

            // c. Display products in descending order of price
            Console.WriteLine("\n--- c. Products Ordered by Price Descending ---");
            var orderedProducts = products.OrderByDescending(p => p.Price);
            foreach (var item in orderedProducts) Console.WriteLine(item);

            // Left Join to display Brand Name (as per images)
            Console.WriteLine("\n--- LIST WITH BRAND NAME (Ref Image) ---");
            var query = from product in products
                        join brand in brands on product.Brand equals brand.ID into t
                        from brand in t.DefaultIfEmpty()
                        select new {
                            name = product.Name,
                            brand = (brand == null) ? "NO-BRAND" : brand.Name,
                            price = product.Price
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
