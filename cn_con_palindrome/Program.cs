using System;

namespace cn_con_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp, r, sum = 0;
            Console.Write("Enter a number");
            String str = Console.ReadLine();
            int input = int.Parse(str);
            temp = input;
            while (input > 0)
            {
                r = input % 10;
                sum = (sum * 10) + r;
                input = input / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The number is palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome");
            }
        }
    }
}
