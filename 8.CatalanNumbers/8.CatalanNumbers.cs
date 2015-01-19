using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Result = 1");
            }
            else
            {
                BigInteger result = CalcFact(2 * n) / (CalcFact(n + 1) * CalcFact(n));
                Console.WriteLine("Result = {0}", result);
            }
        }
        private static BigInteger CalcFact(int input)
        {
            BigInteger fact = input;
            for (int i = input - 1; i >= 2; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
