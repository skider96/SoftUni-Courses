using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = price * 0.18;
            double finalprice = price - discount;
            
            Console.WriteLine($"The final price is: {finalprice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
