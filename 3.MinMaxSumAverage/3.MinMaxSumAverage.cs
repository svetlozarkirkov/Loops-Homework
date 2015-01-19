using System;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}: ",i);
                int temp = int.Parse(Console.ReadLine());
                sum += temp;

                if (temp > max)
                {
                    max = temp;
                }
                if (temp < min)
                {
                    min = temp;
                }
            }

            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3}",
                min,max,sum,((double)sum/n).ToString("F2"));
        }
    }
}
