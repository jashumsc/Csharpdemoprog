using System;

namespace cn_con_prim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            String strnum = Console.ReadLine();
            int n = int.Parse(strnum);
            int prim = 0;
            if (n == 0 || n == 1)
            {
                prim = 1;

            }
            for (int i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    prim = 1;
                    break;
                }
            }
            if (prim == 0)
            {
                Console.WriteLine("The number is prime number");
            }
            else
            {
                Console.WriteLine("The number is not prime number");
            }
        }
    }
}