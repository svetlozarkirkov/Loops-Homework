using System;
using System.Linq;

namespace RandomizeTheNumbers1toN
{
    class RandomizeTheNumbers1toN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0, j = 1; i < n; i++,j++)
            {
                array[i] = j;
            }
            int[] randomized = array.OrderBy(g => Guid.NewGuid()).ToArray();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",randomized[i]);
            }
            Console.WriteLine();
        }
    }
}
