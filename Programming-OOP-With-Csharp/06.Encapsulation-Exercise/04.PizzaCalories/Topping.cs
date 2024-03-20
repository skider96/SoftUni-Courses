
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const double baseCalories = 2;
        const double meatCalories = 1.2;
        const double veggiesCalories = 0.8;
        const double cheeseCalories = 1.1;
        const double sauceCalories = 0.9;
        public string Name { get; }
        private double weight;
        private string ingridient;

        public Topping(string name, string ingridient, double weight)
        {
            Name = name;
            Ingridient = ingridient;
            Weight = weight;
        }

        public string Ingridient
        {
            get => ingridient;
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                ingridient = value;
            }
        }


        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{this.Ingridient} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double GetCalories()
        {
            double ingridientModifier = 0;
            if (Ingridient.ToLower() == "meat")
            {
                ingridientModifier = meatCalories;
            }
            else if (Ingridient.ToLower() == "veggies")
            {
                ingridientModifier = veggiesCalories;
            }
            else if (Ingridient.ToLower() == "cheese")
            {
                ingridientModifier = cheeseCalories;
            }
            else if (Ingridient.ToLower() == "sauce")
            {
                ingridientModifier = sauceCalories;
            }

            double calories = Weight * baseCalories * ingridientModifier;

            return calories;
        }
    }
}