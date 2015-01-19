using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Decimal = ");
            long decim = long.Parse(Console.ReadLine());
            long remainder;
            string binaryResult = string.Empty;
            while (decim > 0)
            {
                remainder = decim % 2;
                decim /= 2;
                binaryResult = remainder.ToString() + binaryResult;
            }
            Console.WriteLine("Binary = {0}", binaryResult);
        }
    }
}
