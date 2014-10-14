using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer
{
    class Payment : ICloneable
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }


        public object Clone()
        {
            return new Payment(this.ProductName, this.Price);
        }
    }
}
