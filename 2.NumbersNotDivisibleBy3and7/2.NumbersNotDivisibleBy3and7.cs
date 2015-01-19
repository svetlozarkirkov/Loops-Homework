using System;

namespace NumbersNotDivisibleBy3and7
{
    class NumbersNotDivisibleBy3and7
    {
        static void Main()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();
        }
    }
}
