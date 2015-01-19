using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0, a = 1; i < n; i++,a++)
            {
                for (int j = 0, k = a; j < n; j++)
                {
                    Console.Write("{0} ",k.ToString().PadLeft(3));
                    k++;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
