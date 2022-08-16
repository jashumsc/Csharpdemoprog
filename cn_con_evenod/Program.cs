using System;

namespace cn_con_evnodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            String str = Console.ReadLine();
            int num = int.Parse(str);
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
