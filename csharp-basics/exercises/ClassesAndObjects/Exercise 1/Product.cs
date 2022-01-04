namespace Exercise_1
{
    public class Product
    {
        public Product(string name, double price, int amount)
        {
            _name = name;
            Price = price;
            Amount = amount;
        }

        private string _name;
        public double Price { get; set; }
        public int Amount { get; set; }

        public string PrintProduct()
        {
            return $"{_name} price {Price:0.00} EUR, amount {Amount}";
        }
    }
}