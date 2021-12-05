using System;
using System.Dynamic;
using static System.Console;

namespace Exercise_1
{
    class Product
    {
        private static string _name;
        private static double _priceAtStart;
        private static int _amountAtStart;

        public Product(string name, double price, int amount)
        {
            _name = name;
            _priceAtStart = price;
            _amountAtStart = amount;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name} price {_priceAtStart:0.00} EUR, amount {_amountAtStart}");
        }

        public double SetPrice(double newPrice)
        {
            return _priceAtStart = newPrice;
        }

        public int ChangeAmount(int newAmount)
        {
            return _amountAtStart = newAmount;
        }
    }
}