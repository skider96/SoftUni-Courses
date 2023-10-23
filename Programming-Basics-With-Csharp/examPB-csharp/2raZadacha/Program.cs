using System;

namespace _2raZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiDniOtsustvie = int.Parse(Console.ReadLine());
            int ostavenaHranaVKilogrami = int.Parse(Console.ReadLine());
            double hranaZaDenElen1 = double.Parse(Console.ReadLine()); 
            double hranaZaDenElen2 = double.Parse(Console.ReadLine());
            double hranaZaDenElen3 = double.Parse(Console.ReadLine());

            double nujnaHrana = broiDniOtsustvie * hranaZaDenElen1 + broiDniOtsustvie * hranaZaDenElen2
                + broiDniOtsustvie * hranaZaDenElen3;
            if (ostavenaHranaVKilogrami >= nujnaHrana)
            {
                Console.WriteLine($"{Math.Floor(ostavenaHranaVKilogrami - nujnaHrana)} kilos of food left");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(nujnaHrana - ostavenaHranaVKilogrami)} more kilos of food are needed");
            }
            




        }
    }
}
