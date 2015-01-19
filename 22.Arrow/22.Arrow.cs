using System;

namespace Arrow
{
    class Arrow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int widthHeight = n + 2 * (n / 2);
            int x = 1;
            int y = widthHeight - 4;

            for (int i = 0; i < widthHeight + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write(new string('#', n));
                    Console.Write(new string('.', n / 2));
                    Console.WriteLine();
                }
                else if (i > 0 && i < n - 1)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write(new string('#', 1));
                    Console.Write(new string('.', n - 2));
                    Console.Write(new string('#', 1));
                    Console.Write(new string('.', n / 2));
                    Console.WriteLine();
                }
                else if (i == n)
                {
                    Console.Write(new string('#', (n / 2) + 1));
                    Console.Write(new string('.', n - 2));
                    Console.Write(new string('#', (n / 2) + 1));
                    Console.WriteLine();
                }
                else if (i > n && i <= widthHeight && y > 0)
                {
                    Console.Write(new string('.', x));
                    Console.Write(new string('#', 1));
                    Console.Write(new string('.', y));
                    Console.Write(new string('#', 1));
                    Console.Write(new string('.', x));
                    Console.WriteLine();
                    x++;
                    y -= 2;
                }
                else if (i == widthHeight)
                {
                    Console.Write(new string('.', n - 1));
                    Console.Write(new string('#', 1));
                    Console.Write(new string('.', n - 1));
                    Console.WriteLine();
                }
            }
        }
    }
}