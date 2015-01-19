using System;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Hexadecimal = ");
            string hex = Console.ReadLine();
            long result = 0;
            for (int i = 0, j = 0, k=hex.Length-1; i < hex.Length; i++,k--)
            {
                if (hex[i]=='A')
                {
                    j = 10;
                }
                else if (hex[i]=='B')
                {
                    j = 11;
                }
                else if (hex[i]=='C')
                {
                    j = 12;
                }
                else if (hex[i]=='D')
                {
                    j = 13;
                }
                else if (hex[i]=='E')
                {
                    j = 14;
                }
                else if (hex[i]=='F')
                {
                    j = 15;
                }
                else
                {
                    j = Convert.ToInt32(hex[i].ToString());
                }
                result += (long)(j*Math.Pow(16, k));
            }
            Console.WriteLine("Decimal = {0}",result);
        }
    }
}
