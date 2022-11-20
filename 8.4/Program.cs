using System;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение А");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j >= 0; j--)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Решение Б");
            int a = 25;
            for (int i = 20; i > 15; i--)
            {
                for (int j = i; j < a; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
                a -= 2;
            }
            Console.WriteLine("Решение В");
            for (int i = 30; i > 25; i--)
            {
                for (int j = i; j < 31; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Решение Г");
            int[] c = { 6, 5, 4, 3, 2 };
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                    Console.WriteLine(2);
                else
                {
                    c[i] = 6 + i;
                    for (int j = i; j < 5; j++)
                        Console.Write(c[j] + " ");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
