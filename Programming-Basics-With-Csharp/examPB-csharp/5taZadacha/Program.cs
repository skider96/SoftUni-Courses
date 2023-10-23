using System;
using static System.Net.Mime.MediaTypeNames;

namespace _5taZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

           int dni = 0;
            int sum = 0;
            while ( text != "END" )
            {
                int izkacheniMetri = int.Parse(Console.ReadLine());
                sum += izkacheniMetri;
               
                if (sum + 5364 >= 8848) { Console.WriteLine($"Goal reached for {dni} days!"); break; }
             

                
                if ( dni >= 5) { break;  }
                text = Console.ReadLine();
                dni++;

            }

            if (sum + 5364 < 8848)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{sum + 5364}");
            }
           
          
        }
    }
}
