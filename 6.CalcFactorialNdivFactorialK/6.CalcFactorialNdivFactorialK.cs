using System;

namespace CalcFactorialNdivFactorialK
{
    class CalcFactorialNdivFactorialK
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int factN = n;
            int factK = k;
            
            for (int i = n-1; i >= 2; i--)
            {
                if (i <= k-1)
                {
                    factK = factK*i;
                    factN = factN*i;
                }
                else
                {
                    factN = factN*i;
                }
            }
            Console.WriteLine("n! = {0}\nk! = {1}",factN,factK);
            Console.WriteLine("n!/k! = {0}",factN/factK);
        }
    }
}
