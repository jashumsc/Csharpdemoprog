using System;

namespace cn_con_swapwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            string str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping 1st number is " + num1);
            Console.WriteLine("After swapping 2nd number is " + num2);
        }
    }
}
