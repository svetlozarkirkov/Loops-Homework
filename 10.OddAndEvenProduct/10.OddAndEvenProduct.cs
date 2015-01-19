using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("numbers = ");
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 1; i <= split.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddProduct *= Convert.ToInt32(split[i - 1].ToString());
                }
                else
                {
                    evenProduct *= Convert.ToInt32(split[i - 1].ToString());
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes\nproduct = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",oddProduct,evenProduct);
            }
        }
    }
}
