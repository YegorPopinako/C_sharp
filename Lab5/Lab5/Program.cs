using System;
using System.Globalization;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[m, n];

            Console.WriteLine("Fill your matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            int min = matrix[0, 0], indexImin = 0, indexJmin = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        indexImin = i;
                        indexJmin = j;
                    }
                }
            }

            Console.WriteLine("The row with the Min element: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[indexImin, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The column with the Min element: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(matrix[i, indexJmin] + " ");
            }
            Console.WriteLine();



            int max = matrix[0, 0], indexImax = 0, indexJmax = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        indexImax = i;
                        indexJmax = j;
                    }
                }
            }

            Console.WriteLine("The row with the Max element: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[indexImax, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The column with the Max element: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(matrix[i, indexJmax] + " ");
            }
            Console.WriteLine();
        }
    }
}