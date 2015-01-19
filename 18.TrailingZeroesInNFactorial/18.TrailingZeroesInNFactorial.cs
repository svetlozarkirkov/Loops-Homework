using System;

namespace TrailingZeroesInNFactorial
{
    class TrailingZeroesInNFactorial
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int zeroes = 0;

            if (n == 5)
            {
                Console.WriteLine("Trailing zeroes in n! = 1");
                return;
            }
            else
            {
                for (int i = 5; n/i >= 1; i *= 5)
                {
                    zeroes += n / i;
                }
            }

            Console.WriteLine("Trailing zeroes in n! = {0}",zeroes);
        }
    }
}
