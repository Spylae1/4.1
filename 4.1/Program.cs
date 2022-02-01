using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            Console.WriteLine("Ввести число ");
            K = Convert.ToInt32(Console.ReadLine());
            int[] mas1 = { 1, 3, 4, 8, 6, 9 };
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < K; i++)
            {

                Console.WriteLine(mas1[i]);
            }

            if (mas1[^1] > K)
            {
                Console.WriteLine("Результат: " + (mas1[^1]));
            }
            else
                Console.WriteLine(" Результат 0");
        }
    }
}
