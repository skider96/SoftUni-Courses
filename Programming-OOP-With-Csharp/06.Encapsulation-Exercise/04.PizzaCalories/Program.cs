using System.Xml.Linq;

namespace _04.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string pizzaType = firstLine[0];
            string pizzaName = firstLine[1];

            string[] secondLine = Console.ReadLine().ToLower().Split();
            string ingridientType = secondLine[0];
            string flourType = secondLine[1];
            string technique = secondLine[2];
            double weightDough = double.Parse(secondLine[3]);

            try
            {
                Pizza pizza = new Pizza(pizzaType, pizzaName);
                try
                {
                    Dough dough = new(ingridientType, flourType, technique, weightDough);
                    pizza.Dough = dough;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] input = command.Split();

                    string topping = input[0].ToLower();
                    string toppingType = input[1];
                    double weight = double.Parse(input[2]);
                    try
                    {
                        Topping toppingPizza = new(topping, toppingType, weight);
                        pizza.Toppings.Add(toppingPizza);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Environment.Exit(0);
                    }
                }

                try
                {
                    pizza.ToppingsCount();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
                Console.WriteLine(pizza.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }
}