using System;
using System.Numerics;

namespace CalculateNumberOfCombinations
{
    class CalculateNumberOfCombinations
    {
        static void Main()
        {
            //Your task is to write a program that calculates n! / (k! * (n-k)!) 
            //for given n and k (1 < k < n < 100). Try to use only two loops.

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            
            Console.WriteLine("N! = {0}\nK! = {1}\n(N-K)! = {2}",CalcFact(n),CalcFact(k),CalcFact(n-k));
            BigInteger result = CalcFact(n) / (CalcFact(k) * CalcFact(n-k));
            Console.WriteLine("Result = {0}",result);
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
