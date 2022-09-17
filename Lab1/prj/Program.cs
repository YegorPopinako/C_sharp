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

            double x = 0;
            double result = 0;

            bool isXok = false;


            do
            {
                Console.Write("Enter a X. x=");
                string strX = Console.ReadLine();
                isXok = double.TryParse(strX, out x);
                if (!isXok)
                {
                    Console.WriteLine("Mistake while entering");

                }
            } while (!isXok);


                result = (2 * Math.Pow(x, 4)) - (3 * Math.Pow(x, 3)) + (2 * Math.Pow(x, 2)) - (5 * x) + 6;//your formula goes here


            Console.Write("result = {0} , x={1}", result, x);
        }
    }
}