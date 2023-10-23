using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1111; i <= 9999; i++)
            {
                int currentNumber = i;
                bool uslovie = true;
                
                while (currentNumber != 0)
                {
                    int lastNumber = currentNumber % 10;
                    if (lastNumber == 0 || n % lastNumber != 0)
                    {
                        uslovie = false;
                        break;
                    }
                    currentNumber /= 10;
                   
                }
                if (uslovie)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
