using System;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Binary = ");
            string input = Console.ReadLine();
            long decim = 0L;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[input.Length - i - 1] == '0')
                {
                    continue;
                }
                decim += (long)Math.Pow(2, i);
            }
            Console.WriteLine("Decimal = {0}",decim);
        }
    }
}
