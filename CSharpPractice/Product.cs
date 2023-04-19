using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Product
    {
        public Product() { }

        public Product(int productId) 
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }  // ? - nullable type (can be 0 but not null)
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
    }
}
