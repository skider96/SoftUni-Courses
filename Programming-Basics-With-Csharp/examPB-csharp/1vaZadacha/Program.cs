using System;

namespace _1vaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiHoraOtGrupata = int.Parse(Console.ReadLine());
            int broiNoshtuvki = int.Parse(Console.ReadLine());
            int kartiZaTransport = int.Parse(Console.ReadLine());
            int broiBiletiZaMuzei = int.Parse(Console.ReadLine());

            int noshtuvka = broiNoshtuvki * 20;
            double kartaZaTransport = kartiZaTransport * 1.60;
            int biletZaMuzei = broiBiletiZaMuzei * 6;

            double obshtaSumaZaEdinChovek = noshtuvka + kartaZaTransport + biletZaMuzei;
            double SumaZaVsichkiBezProcenti = broiHoraOtGrupata * obshtaSumaZaEdinChovek;

            double vsichko = SumaZaVsichkiBezProcenti + SumaZaVsichkiBezProcenti * 0.25;
            Console.WriteLine($"{vsichko:f2}");


        }
    }
}
