using System;

namespace _3taZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dniPrestoi = int.Parse(Console.ReadLine());
            string vidPomeshtenie = Console.ReadLine();
            string ocenka = Console.ReadLine();

            int noshtuvki = dniPrestoi - 1;
            double pricePerNight = 0;
            if (vidPomeshtenie == "room for one person")
            {
                pricePerNight = 18;
            }
            else if ( vidPomeshtenie == "apartment")
            {
                pricePerNight = 25;
                if ( noshtuvki < 10)
                {
                   pricePerNight = pricePerNight - pricePerNight * 0.30;
                }
                else if ( noshtuvki <= 15)
                {
                    pricePerNight = pricePerNight - pricePerNight * 0.35;
                }
                else
                {
                    pricePerNight = pricePerNight - pricePerNight * 0.50;
                }
            }
            else if ( vidPomeshtenie == "president apartment")
            {
                pricePerNight = 35;
                if (noshtuvki < 10)
                {
                    pricePerNight = pricePerNight - pricePerNight * 0.10;
                }
                else if (noshtuvki <= 15)
                {
                    pricePerNight = pricePerNight - pricePerNight * 0.15;
                }
                else
                {
                    pricePerNight = pricePerNight - pricePerNight * 0.20;
                }
            }

            double cenaPrestoi = pricePerNight * noshtuvki;
            if (ocenka == "positive") { cenaPrestoi = cenaPrestoi + cenaPrestoi  * 0.25; }
            else if (ocenka == "negative") { cenaPrestoi = cenaPrestoi - cenaPrestoi * 0.10; }

            Console.WriteLine($"{cenaPrestoi:f2}");
        }
    }
}
