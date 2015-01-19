using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace OddEvenElements
{
    class OddEvenElements
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            string input = Console.ReadLine();
            string[] nums = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] numsArray = Array.ConvertAll(nums, double.Parse);

            List<double> odds = new List<double>();
            List<double> evens = new List<double>();

            double oddsum = 0;
            double evensum = 0;


            if (numsArray.Length > 1)
            {
                for (int i = 0; i < numsArray.Length; i += 2)
                {
                    odds.Add(numsArray[i]);
                    oddsum += numsArray[i];
                }

                for (int i = 1; i < numsArray.Length; i += 2)
                {
                    evens.Add(numsArray[i]);
                    evensum += numsArray[i];
                }

                double oddMin = Math.Round(odds.Min(), 2);
                double oddMax = Math.Round(odds.Max(), 2);
                double evenMin = Math.Round(evens.Min(), 2);
                double evenMax = Math.Round(evens.Max(), 2);

                Console.Write("OddSum=" + Math.Round(oddsum, 2) + ", " +
                    "OddMin=" + oddMin + ", " +
                    "OddMax=" + oddMax + ", " +
                    "EvenSum=" + Math.Round(evensum, 2) + ", " +
                    "EvenMin=" + evenMin + ", " +
                    "EvenMax=" + evenMax);
                Console.WriteLine();
            }
            else if (numsArray.Length == 1)
            {
                for (int i = 0; i < numsArray.Length; i += 2)
                {
                    odds.Add(numsArray[i]);
                    oddsum += numsArray[i];
                }

                double oddMin = odds.Min();
                double oddMax = odds.Max();

                Console.Write("OddSum=" + Math.Round(oddsum, 2) + ", " +
                    "OddMin=" + oddMin + ", " +
                    "OddMax=" + oddMax + ", " +
                    "EvenSum=" + "No" + ", " +
                    "EvenMin=" + "No" + ", " +
                    "EvenMax=" + "No");
                Console.WriteLine();
            }
            else
            {
                Console.Write("OddSum=" + "No" + ", " +
                    "OddMin=" + "No" + ", " +
                    "OddMax=" + "No" + ", " +
                    "EvenSum=" + "No" + ", " +
                    "EvenMin=" + "No" + ", " +
                    "EvenMax=" + "No");
                Console.WriteLine();
            }
        }
    }
}