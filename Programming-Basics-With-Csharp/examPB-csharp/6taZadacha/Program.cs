using System;

namespace _6taZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int proizvedenie = 0;
            double obshto = 0;
            for (int a = 1; a < 9; a++)
            {
                for (int b = 9 - 1; b >= 1; b--)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        for (int d = 9 - 1; d >= 0; d--)
                        {
                            sum = a + b + c + d;
                            proizvedenie = a * b * c * d;
                            obshto = 1.0 * sum / proizvedenie;
                            if ((sum == proizvedenie) && n % 5 == 0)
                            {
                                Console.Write($"{a}{b}{c}{d}"); break'
                            }
                            else if (obshto == 3 && n % 3 == 0)
                            {
                                Console.Write($"{d}{c}{b}{a}"); break;
                            }
                            else
                            {
                                Console.WriteLine("Nothing found");
                                break;
                            }


                        }
                    }
                }

            }
        }
    }
}
