namespace Exercise_1
{

    class Product
    {
        public Product(string name, double price, int amount)
        {
            _name = name;
            PriceAtStart = price;
            AmountAtStart = amount;
        }
        private string _name { get; set; }
        public double PriceAtStart { get; set; }
        public int AmountAtStart { get; set; }

        public string PrintProduct()
        {
            return $"{_name} price {PriceAtStart:0.00} EUR, amount {AmountAtStart}";
        }
    }
}