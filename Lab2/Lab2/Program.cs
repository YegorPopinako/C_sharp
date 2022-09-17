using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DUT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            int k = 0;
            int nn = 0;
            int nk = 0;
            double result = 0;

            bool isNNok = false;
            bool isNKok = false;


            do
            {
                Console.Write("Enter a NN. NN=");
                string strU = Console.ReadLine();
                isNNok = int.TryParse(strU, out nn);
                if (!isNNok && nn < 0)
                {
                    Console.WriteLine("Mistake while entering");

                }
            } while (!isNNok);


            do
            {
                Console.Write("Enter NK. NK=");
                string strR = Console.ReadLine();
                isNKok = int.TryParse(strR, out nk);
                if (!isNKok && nk < 0)
                {
                    Console.WriteLine("Mistake while entering");
                }
            } while (!isNKok);


            for (k = nn; k < nk; k++)
            {
                result *= (Math.Pow(k, 2) + Math.Pow(-1, (Math.Pow(k, 2) + Math.Pow(-1, k) * k)) * k) / (3 * Math.Pow(k ,2) +5);//your formula goes here
            }

            Console.Write("result = {0} , nn={1}, nk={2}", result, nn, nk);
        }
    }
}