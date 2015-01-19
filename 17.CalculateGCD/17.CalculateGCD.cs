using System;

namespace CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int gcd = 0;
            for (int i = 1; i <= Math.Max(a,b); i++)
            {
                if (i==0)
                {
                    continue;
                }
                else if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine("GCD = {0}",gcd);
        }
    }
}
