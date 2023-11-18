using System.Reflection.Metadata.Ecma335;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{name} {price} {quantity}"
            Dictionary<string, Products> products = new Dictionary<string, Products>();
            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split();
                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                Products addedProducts = new Products(name, quantity, price);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, addedProducts);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.Value);
            }
        }
    }

    class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Products(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} -> {(Price * Quantity):f2}";
        }
    }
}
