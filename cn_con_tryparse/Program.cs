using System;

namespace cn_con_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num);
        }
    }
}
