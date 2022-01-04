using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Banana", 1.1, 13);
            var product2 = new Product("Logitech mouse", 70.00, 14);
            var product3 = new Product("iPhone 5s", 999.99, 3);
            var product4 = new Product("Epson EB-U05", 440.46, 1);
            product1.Amount = 5;
            product2.Price = 600;

            var products = new Product[]
            {
                product1,
                product2,
                product3,
                product4
            };

            foreach (var prod in products)
            {
                Console.WriteLine(prod.PrintProduct());
            }
        }
    }
}
