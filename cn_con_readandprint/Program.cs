using System;

namespace cn_con_readandprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.Write("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Enter the "+n+" number of elements:");
            for(int i = 0; i < n; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }
            Console.Write("The elements are :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}
