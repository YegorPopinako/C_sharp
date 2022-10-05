using System;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace Home
{
    class Program
    {
        //Recursed
        static int switchingNum, addingNum = 0;
        static int RecRevEnter(int n)
        {
            if (n != 0)
            {
                switchingNum = n % 10;
                addingNum = addingNum * 10 + switchingNum;
                n /= 10;
                return RecRevEnter(n);
            }
            return addingNum;
        }


        static string start2 = "";
        static string RecRevEnter(string value, int m)
        {
            char[] stringConverted = value.ToCharArray();
            if (m != 0)
            {
                m--;
                start2 = start2 + stringConverted[m];
                string str = new string(stringConverted);
                return RecRevEnter(str, m);
            }

            return start2;
        }



        //Overloaded
        static int MetRevEnter(int value)
        {
            int switchingNum, addingNum = 0;
            while (value != 0)
            {
                switchingNum = value % 10;
                addingNum = addingNum * 10 + switchingNum;
                value /= 10;
            }
            return addingNum;
        }


        static string MetRevEnter(string value)
        {
            char[] stringConverted = value.ToCharArray();
            string start2 = "";
            for (int i = stringConverted.Length - 1; i >= 0; i--)
            {
                start2 = start2 + stringConverted[i];
            }

            return start2;
        }




        static double MetRevEnter(double value)
        {
            int switchingNumber1, addingNumber1 = 0; int switchingNumber2, addingNumber2 = 0;

            string strNum = Convert.ToString(value);
            int length = strNum.Length;
            int k = 0;
            for (int i = 0; i < length; i++)
            {
                if (strNum[i] == ',')
                {
                    //defining the amount of numbers after Comma
                    k = length - i - 1;
                }
            }

            //определяем на сколько нужно множить число после точки
            int g = 1;
            for (int i = 0; i < k; i++)
            {
                g *= 10;
            }

            int integer = Convert.ToInt32(Math.Truncate(value));//Integer Part
            int fractionalNumbers = Convert.ToInt32((value - Math.Truncate(value)) * g); //Fractional Part

            //Разворачиваем часть до точки
            while (integer != 0)
            {
                switchingNumber1 = integer % 10;
                addingNumber1 = addingNumber1 * 10 + switchingNumber1;
                integer /= 10;
            }

            //Разворачиваем часть после точки
            while (fractionalNumbers != 0)
            {
                switchingNumber2 = fractionalNumbers % 10;
                addingNumber2 = addingNumber2 * 10 + switchingNumber2;
                fractionalNumbers /= 10;
            }

            //no comments
            string string1 = addingNumber1.ToString();
            string string2 = addingNumber2.ToString();

            string Final = "";
            for (int i = 0; i < string1.Length; i++)
            {
                Final += string1[i];
            }

            Final += ",";

            for (int i = 0; i < string2.Length; i++)
            {
                Final += string2[i];
            }

            double Result = Convert.ToDouble(Final);
            return Result;
        }




        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string start = "Hello";
            int m = start.Length;

            double num = 1234.45667;


            Console.WriteLine("reverse int: " + RecRevEnter(n) + "\n");
            Console.WriteLine("reverse string: " + RecRevEnter(start, m) + "\n");

            Console.WriteLine("reverse int: " + MetRevEnter(n) + "\n");
            Console.WriteLine("reverse string: " + MetRevEnter(start) + "\n");
            Console.WriteLine("reverse double: " + MetRevEnter(num) + "\n");
        }
    }
}
