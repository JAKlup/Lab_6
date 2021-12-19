using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесвто строк и столбцов квадратной матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] martix = new int[n, n];
            int[,] martixATMD = new int[n, n];
            int[,] matrixOTSD = new int[n, n];
            Random rand = new Random();
            Console.WriteLine("Исходная матрица:");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    martix[i, j] = rand.Next(n * n);
                    Console.Write(martix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Транспонирование матрицы по главной диагонали:");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    martixATMD[i, j] = martix[j, i];
                    Console.Write(martixATMD[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Транспонирование матрицы по побочной диагонали:");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    matrixOTSD[i, j] = martix[(n - 1) - j, (n - 1) - i];
                    Console.Write(matrixOTSD[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
