using System;

namespace PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main()
        {
            int[] cards1 = new int[9] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] cards2 = new string[4] { "J", "Q", "K", "A" };
            string[] colors = new string[4] { "♣", "♦", "♥", "♠" };

            for (int i = 2; i <= 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(cards1[i - 2] + colors[j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(cards2[i] + colors[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
