using System;

namespace cn_con_empstr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            String word = Console.ReadLine();
            int len = word.Length;
            Console.WriteLine(len);
        }
    }
}
