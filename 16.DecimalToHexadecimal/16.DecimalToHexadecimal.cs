using System;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Decimal = ");
            long dec = long.Parse(Console.ReadLine());
            Console.Write("Hexadecimal = ");
            ToHexadecimal(dec);
            Console.WriteLine();
            
        }
        static void ToHexadecimal(long n)
        {
            if (n == 0)
                return;
            else
            {
                long r = n % 16;
                n = n/ 16;
                ToHexadecimal(n);
                
                switch (r)
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    default:
                        Console.Write(r);
                        break;
                }
            }
        }
    }
}
