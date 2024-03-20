using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string pizzaType;
        private string name;
        private Dough dough;
        private List<Topping> toppings;



        public Pizza(string pizzaType, string name)
        {
            this.pizzaType = pizzaType;
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
            
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == string.Empty || value.Length > 15 || value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough { get; set; }

        public List<Topping> Toppings
        {
            get => toppings;
            set
            {
                if (toppings.Count > 10)
                {
                    throw new Exception("Number of toppings should be in range [0..10].");
                }
                toppings = value;
            }
        }

        public double ALlCalories()
        {
            double calories = 0;
            calories += Dough.GetCalories();

            foreach (var topping in Toppings)
            {
                calories += topping.GetCalories();
            }

            return calories;
        }

        public void ToppingsCount()
        {
            if (Toppings.Count > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
        }

        public override string ToString()
        {
            return $"{Name} - {ALlCalories():f2} Calories.";
        }
    }
}
