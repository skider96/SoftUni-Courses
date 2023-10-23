using System;

namespace _4taZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nBroiDni = int.Parse(Console.ReadLine());
            double sumRakiq = 0;
            double sumGradusi = 0;
            double smetkaGradusi = 0;

            for (int i = 1; i <= nBroiDni; i++)
            {
                double kolichestvoRakiq = double.Parse(Console.ReadLine());
                double gradusi = double.Parse(Console.ReadLine());
                smetkaGradusi = kolichestvoRakiq * gradusi;
                sumRakiq += kolichestvoRakiq;
                sumGradusi += smetkaGradusi;
                
            }

            double srednaStoinostGradusi = sumGradusi / sumRakiq;
            Console.WriteLine($"Liter: {sumRakiq:f2}");
            Console.WriteLine($"Degrees: {srednaStoinostGradusi:f2}");
            if ( srednaStoinostGradusi < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (srednaStoinostGradusi <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
