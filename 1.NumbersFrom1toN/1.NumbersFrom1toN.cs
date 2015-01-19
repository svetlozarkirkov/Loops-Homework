using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 1; i <= n; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
