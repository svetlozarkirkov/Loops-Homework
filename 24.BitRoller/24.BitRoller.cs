using System;
using System.Collections.Generic;

namespace BitRoller
{
    class BitRoller
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint f = uint.Parse(Console.ReadLine());
            uint r = uint.Parse(Console.ReadLine());
            List<int> binary = new List<int>();
            string binaryNum = Convert.ToString(n, 2).PadLeft(19, '0');
            for (int i = 0; i < binaryNum.Length; i++)
            {
                binary.Add(Convert.ToInt32(binaryNum[i].ToString()));
            }
            int extractedBit = binary[(int)(18 - f)];
            binary.RemoveAt((int)(18 - f));
            string missing = string.Join("", binary);
            for (int i = 0; i < r; i++)
            {
                missing = missing.PadLeft(19, missing[missing.Length - 1]);
                missing = missing.Remove(missing.Length - 1);
            }
            List<int> final = new List<int>();
            for (int i = 0; i < missing.Length; i++)
            {
                final.Add(Convert.ToInt32(missing[i].ToString()));
            }
            final.Insert((int)(18 - f), extractedBit);
            string finale = string.Join("", final);
            Console.WriteLine(Convert.ToUInt32(finale, 2));
        }
    }
}