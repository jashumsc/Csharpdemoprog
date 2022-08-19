using System;
using System.Collections.Generic;
using System.Text;

namespace cn_con_aggregratedclass
{
    internal class Shop
    {
        public int ProductId;
        public string ProductName;
        public int Quantity;
        public decimal Price;


        public override string ToString()
        {
            return $"{ProductId} {ProductName,-20} {Quantity,5} {Price,15:C}";
        }
    }
}