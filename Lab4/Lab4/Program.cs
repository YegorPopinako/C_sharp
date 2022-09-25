using System;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b;
            int[] c;
            int[] d;

            if (n > k)
            {
                //array b
                b = new int[n - k];
                Console.WriteLine("Array a");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }


                Console.WriteLine();


                Console.WriteLine("Array b");
                for (int i = k, j = 0; i < a.Length; i++, j++)
                {
                    b[j] = a[i];
                    Console.Write(b[j] + " ");
                }


                //array c
                c = new int[n - k];

                Console.WriteLine();

                Console.WriteLine("Array c");
                for (int i = k + 1, j = 0; i < a.Length; i++, j++)
                {
                    c[j] = a[i];
                    Console.Write(c[j] + " ");
                }


                //array d
                d = new int[n];

                Console.WriteLine();

                Console.WriteLine("Array d");
                for (int i = k, j = k; i < a.Length; i++, j++)
                {
                    d[j] = a[i];
                    Console.Write(d[j] + " ");
                }
            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}