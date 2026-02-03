using System;

namespace Lab3
{
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double cost, int quantity)
        {
            Name = name;
            Cost = cost;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Product [Name={Name}, Cost={Cost:C}, Quantity={Quantity}]";
        }
    }
}
