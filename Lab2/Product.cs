using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Tạo lớp Product với 3 thuộc tính: name, price và discount
    internal class Product
    {
        // Khai báo các trường dữ liệu với phạm vi truy cập 'private'
        private string _name;
        private double _price;
        private double _discount;

        // Thêm các phương thức getter và setter để đọc và ghi dữ liệu
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        // Constructor thứ nhất có 3 tham số: name, price, discount
        public Product(string name, double price, double discount)
        {
            this._name = name;
            this._price = price;
            this._discount = discount;
        }

        // Constructor thứ hai có 2 tham số: name, price (ngầm hiểu discount = 0)
        public Product(string name, double price)
        {
            this._name = name;
            this._price = price;
            this._discount = 0;
        }

        // Constructor mặc định (dùng cho input)
        public Product() { }

        // Phương thức tính thuế nhập khẩu (10% giá sản phẩm), phạm vi truy cập 'private'
        private double getImportTax()
        {
            return this._price * 0.1;
        }

        // Phương thức nhập thông tin sản phẩm từ bàn phím
        public void input()
        {
            Console.WriteLine("Nhập thông tin sản phẩm:");
            Console.Write("Tên sản phẩm: ");
            this._name = Console.ReadLine();

            Console.Write("Giá sản phẩm: ");
            while (!double.TryParse(Console.ReadLine(), out this._price) || this._price < 0)
            {
                Console.Write("Giá không hợp lệ. Vui lòng nhập lại: ");
            }

            Console.Write("Giảm giá: ");
            while (!double.TryParse(Console.ReadLine(), out this._discount) || this._discount < 0)
            {
                Console.Write("Giảm giá không hợp lệ. Vui lòng nhập lại: ");
            }
        }

        // Phương thức hiển thị thông tin ra màn hình, phạm vi truy cập 'public'
        public void display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Tên sản phẩm: " + this._name);
            Console.WriteLine("Giá: " + this._price);
            Console.WriteLine("Giảm giá: " + this._discount);
            Console.WriteLine("Thuế nhập khẩu: " + this.getImportTax());
            Console.WriteLine("-------------------------");
        }
    }
}
