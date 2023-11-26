using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger result = firstNumber * secondNumber;

            Console.WriteLine(result);
        }
    }
}
