using System.Text;

namespace _03.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new();
            List<Product> products = new();

            foreach (var buyer in peopleInput)
            {
                string[] personData = buyer.Split('=').ToArray();
                try
                {
                    Person person = new Person(personData[0], decimal.Parse(personData[1]));

                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            foreach (var prod in productsInput)
            {
                string[] productData = prod.Split("=").ToArray();

                try
                {
                    Product product = new Product()
                    {
                        Name = productData[0],
                        Cost = decimal.Parse(productData[1])
                    };

                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] data = command.Split();
                string personName = data[0];
                string productName = data[1];

                Person buyer = people.Find(p => p.Name == personName);
                Product productBuying = products.Find(p => p.Name == productName);

                if (buyer.Money < productBuying.Cost)
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }
                else
                {
                    buyer.BagOfProducts.Add(productName);
                    Console.WriteLine($"{personName} bought {productName}");
                    buyer.Money -= productBuying.Cost;
                }
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.BagOfProducts.Any())
                {
                    Console.WriteLine(string.Join(", ", person.BagOfProducts));
                }
                else
                {
                    Console.Write("Nothing bought");
                }
            }
        }
    }
}
/*
Peter=11;George=4
Bread=10;Milk=2;
Peter Bread
George Milk
George Milk
Peter Milk
END
 */