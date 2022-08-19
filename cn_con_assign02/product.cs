using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Assign02
{
    internal class Product : System.IComparable
    {
        private static int productIdCounter;

        static Product()
        {
            Product.productIdCounter = 100;
        }

        public Product()
        {
            this._ProductId = ++Product.productIdCounter;
        }

        private int _ProductId;
        public int ProductId
        {
            get
            {
                return _ProductId;
            }
        }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Cost
        {
            get
            {
                return Price * Quantity;
            }
        }
        
        public override string ToString()
        {
            return $"{ProductId,5} {ProductName,-20} {Quantity,5} {Price,15:C} {Cost,15:C}";
        }

        #region System.IComparable members

        /// <summary>
        ///     Called during any Comparison or Sorting operations of the Employee Object
        /// </summary>
        /// <param name="obj">Object to compare against with the current object </param>
        /// <returns>
        ///     0           this    equal to      otherEmployee
        ///     -negative   this    lesser than   otherEmployee
        ///     +positive   this    greater than  otherEmployee OR otherEmployee == NULL
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Product p = obj as Product;
                return this.ProductName.CompareTo(ProductName);      // ASC order of EmployeeID
                // return empOther.EmployeeID.CompareTo(this.EmployeeID);   // DESC order of EmployeeID
            }
        }

        #endregion
    }
}