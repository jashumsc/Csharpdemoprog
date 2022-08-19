using System;

namespace cn_con_1Dand2Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;          // Declaration
            arr = new int[5];
            Console.WriteLine("Enter 5 elements :");
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();

            Console.WriteLine("2Dimensional array");
            Console.WriteLine("Enter 4 elements :");
            int[,] arr2 = new int[2,2];
            int rows = arr2.GetLength(0);                     // 2 (Rank #1)
            int cols = arr2.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr2[i,j]=int.Parse(Console.ReadLine());
                }
                
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
