using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveSpecialLetters
{
    class FiveSpecialLetters
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('a',5);
            dict.Add('b',-12);
            dict.Add('c',47);
            dict.Add('d',7);
            dict.Add('e',-32);
            char[] chars = new char[5] {'a', 'b', 'c', 'd', 'e'};
            int count = 0;
            List<string> collected = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int m = 0; m < 5; m++)
                            {
                                char[] temp = new char[5]{chars[i],chars[j],chars[k],chars[l],chars[m]};
                                char[] noDupes = temp.Distinct().ToArray();
                                int tempWeight = 0;
                                for (int n = 0, x=1; n < noDupes.Length; n++,x++)
                                {
                                    if (dict.ContainsKey(noDupes[n]))
                                    {
                                        tempWeight += x*dict[noDupes[n]];
                                    }
                                }
                                if (tempWeight>= start && tempWeight <= end)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ",temp[0],temp[1],temp[2],temp[3],temp[4]);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
