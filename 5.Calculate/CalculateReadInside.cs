using System;

namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            //Write a program that, for a given two integer numbers n and x, 
            //calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
            //Use only one loop. Print the result with 5 digits after the decimal point.

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1d;

            for (int i = 1; i <= n; i++)
            {
                sum += CalcFact(i)/Math.Pow(x, i);
            }

            Console.WriteLine("S = {0}",sum.ToString("F5"));
        }
        private static double CalcFact(int input)
        {
            double fact = input;
            for (int i = input - 1; i >= 2; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
