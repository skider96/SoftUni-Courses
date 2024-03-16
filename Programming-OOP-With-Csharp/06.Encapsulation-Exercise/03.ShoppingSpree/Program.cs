namespace _03.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] buyer = Console.ReadLine().Split('=', ';');
            string personName = buyer[0];
            decimal money = decimal.Parse(buyer[1]);
            Person person = new Person();
            try
            {
                person.Name = personName;
                person.Money = money;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            string[] products = Console.ReadLine().Split('=', ';');
            for (int i = 0; i < products.Length; i++)
            {
                
            }
            string productName = products[0];
            decimal cost = decimal.Parse(products[1]);

            Product product = new Product();
            try
            {
                product.Name = productName;
                product.Cost = cost;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            List<Product> productsBag = new List<Product>();
            productsBag.Add(product);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {


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