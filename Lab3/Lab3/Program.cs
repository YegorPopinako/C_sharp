using System;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num: ");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num: ");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third num: ");
            int ThirdNum = Convert.ToInt32(Console.ReadLine());

            if (FirstNum == SecondNum || FirstNum == ThirdNum || SecondNum == ThirdNum)
            { 
                Console.WriteLine("you entered same numbers");
            }
            else
            {
                Console.WriteLine("no same numbers found");
            }
        }
    }
}