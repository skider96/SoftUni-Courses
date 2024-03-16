using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Product
    {
       private string name;
       private decimal cost;

       public Product()
       {
           Name = name;
           Cost = cost;
       }
       public string Name
       {
           get => name;
           set
           {
               if (value == string.Empty)
               {
                   throw new ArgumentException("Name cannot be empty");
               }
               Name = value;
           }
       }

       public decimal Cost
       {
           get => cost;
           set
           {
               if (value < 0)
               {
                   throw new ArgumentException("Money cannot be negative");
               }
               Cost = value;
           }
       }
    }
}
