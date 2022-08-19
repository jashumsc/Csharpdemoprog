using System;

namespace cs_con_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList intList = new System.Collections.ArrayList();

            // BOXING because the .Add(object item)
            intList.Add(10);                    
            intList.Add(20);                    
            intList.Add("Jashwanth s");
            foreach (var item in intList)
            {
                Console.WriteLine("Type: {0}, Value = {1}", item.GetType(), item);
            }
        }
    }
}