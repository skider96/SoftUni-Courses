using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const double white = 1.5;
        private const double wholegrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;

        public string Name { get; }
        private double weight;
        private string flourType;
        private string bakingTechnique;
        public Dough(string name, string flourType, string bakingTechnique, double weight)
        {
            Weight = weight;
            Name = name;
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            GetCalories();
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentOutOfRangeException("Dough weight should be in the range [1..200].");
                }
                
                weight = value;
            } 
        }

        public string FlourType
        {
            get => flourType;
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new Exception("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public double GetCalories()
        {
            double flourModifier = 0;
            if (FlourType == "white")
            {
                flourModifier = white;
            }
            else if (FlourType == "wholegrain")
            {
                flourModifier = wholegrain;
            }

            double bakingModifier = 0;
            if (bakingTechnique == "crispy")
            {
                bakingModifier = crispy;
            }
            else if (bakingTechnique == "chewy")
            {
                bakingModifier = chewy;
            }
            else if (bakingTechnique == "homemade")
            {
                bakingModifier = homemade;
            }

            double calories = (2 * Weight) * flourModifier * bakingModifier;

            return calories;
        }
    }
}
