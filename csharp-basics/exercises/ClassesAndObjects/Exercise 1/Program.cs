using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Banana", 1.1, 13);
            product1.PrintProduct();
            product1.SetPrice(2);
            product1.PrintProduct();
            var product2 = new Product("Logitech mouse", 70.00, 14);
            product2.PrintProduct();
            product2.ChangeAmount(50);
            product2.PrintProduct();
            var product3 = new Product("iPhone 5s", 999.99, 3);
            product3.PrintProduct();
            product3.SetPrice(50);
            product3.PrintProduct();
            var product4 = new Product("Epson EB-U05", 440.46, 1);
            product4.PrintProduct();
            product4.ChangeAmount(5);
            product4.PrintProduct();
        }
    }
}
