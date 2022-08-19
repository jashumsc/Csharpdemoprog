using System;
using System.Collections;

namespace cs_con_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            Console.Write("Enter the number of products:");
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter details of products "+(i+1));
                Product newProduct = GetProductInfo();
                myList.Add(newProduct);
            }
           
                        Console.WriteLine();
                        Console.WriteLine("List of Products in my Application:");
                        // Console.WriteLine($"{"ID"} {"Product Name",-20} {"Qty",5}, {"Price",15}");
                        Console.WriteLine("{0} {1,-20} {2,5}, {3,15}", "ID", "Product Name", "Qty", "Price");
                        for (int i = 0; i < myList.Count; i++)
                        {
                            Console.WriteLine((Product)myList[i]);
                        }
                             
        }

        static Product GetProductInfo()
        {
            Product product;

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Product");
            Console.Write("Product ID : ");
            product.ProductId = int.Parse(Console.ReadLine());
            Console.Write("Product Name : ");
            product.ProductName = Console.ReadLine();
            Console.Write("Quantity : ");
            product.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Price : ");
            product.Price = decimal.Parse(Console.ReadLine());

            return product;
        }
    }
}