using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogfood = double.Parse(Console.ReadLine());
            double catfood = double.Parse(Console.ReadLine());
            double foodprice = dogfood * 2.50 + catfood * 4;
            Console.WriteLine(foodprice + " " + "lv.");
        }
    }
}
