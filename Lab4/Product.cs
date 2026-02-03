using System;

namespace Lab4
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int Brand { get; set; }

        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
        }
    }
}
