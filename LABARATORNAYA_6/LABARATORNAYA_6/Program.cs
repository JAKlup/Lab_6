using System;

namespace LABARATORNAYA_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[50];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 50);
                Console.Write(" " + mas[i]);
            }
            Console.Read();
            int maxMas = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > maxMas)
                {
                    maxMas = mas[i];
                }
            }
            int maxCountValue = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (maxMas == mas[i])
                {
                    maxCountValue++;
                }
            }
            Console.WriteLine("Максиальное значение " + maxMas);
            Console.WriteLine("Максимальное значение повторяется " + maxCountValue + " раз");
        }
    }
}
