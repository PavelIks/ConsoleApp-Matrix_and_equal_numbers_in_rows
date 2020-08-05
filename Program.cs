using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // С List
            /*Console.Write("Ввести число строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ввести число столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            Console.WriteLine("\nИсходная матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(0, 30);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                int[] b = new int[m];
                for (int j = 0; j < m; j++)
                {
                    b[j] = a[i, j];
                }
                var ww = b;
                if (b.Length != ww.Distinct().ToArray().Length)
                {
                    list.Add(new List<int>());
                    foreach (int tmp in b)
                    {
                        list[list.Count() - 1].Add(tmp);
                    }
                }
            }

            Console.WriteLine("\nНовая матрица: ");
            if (list.Count() > 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(list[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Все строки без повторяющихся элементов");
            }
            Console.Read();*/

            // Без List
            /*Console.Write("Ввести число строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ввести число столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            Console.WriteLine("\nИсходная матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(0, 30);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nНовая матрица: ");
            for (int i = 0; i < n; i++)
            {
                int[] b = new int[m];
                for (int j = 0; j < m; j++)
                {
                    b[j] = a[i, j];
                }
                if (b.Length != b.Distinct().Count())
                {
                    foreach (int tmp in b)
                    {
                        Console.Write(tmp + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();*/
        }
    }
}