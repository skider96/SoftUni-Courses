using System;
using System.Threading.Channels;

namespace _04.InchestoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centimeters = double.Parse(Console.ReadLine());
                double inch = centimeters*2.54;
            Console.WriteLine(inch);

        }
    }
}
