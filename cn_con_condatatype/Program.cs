using System;

namespace cn_con_condatatype

    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your Age:");
                String strage = Console.ReadLine();
                int Age = int.Parse(strage);
                Console.WriteLine("You are " + Age + " year old");
            }
        }
    }
   
