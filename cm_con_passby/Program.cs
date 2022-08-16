using System;

namespace cn_con_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Pass by Value");

            Console.WriteLine($"Before calling: i = {num}");
            PassByValue(num);
            Console.WriteLine($"After calling: i = {num}");
            Console.WriteLine();


            Console.WriteLine("Pass by reference");
            Console.WriteLine($"Before calling: i = {num}");
            PassByRefer(ref num);
            Console.WriteLine($"After calling: i = {num}");
            Console.WriteLine();

            Console.WriteLine("Pass by out");
            Console.WriteLine($"Before calling: i = {num}");
            PassByOut(out num);
            Console.WriteLine($"After calling: i = {num}");
            Console.WriteLine();
        }

        static void PassByValue(int x)
        {
            Console.WriteLine($"--- received number = {x}");
            x = x * x;
            Console.WriteLine($"--- after changing, i = {x}");
        }

        static void PassByRefer(ref int x)
        {
            Console.WriteLine($"--- received number = {x}");
            x = x * x;
            Console.WriteLine($"--- after changing, i = {x}");
        }

        static void PassByOut(out int x)
        {
            x = 5;
            x = x * x;
            Console.WriteLine($"--- after changing, i = {x}");
        }
    }
}
