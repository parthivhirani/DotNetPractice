﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Product: EntityBase
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
        public override string ToString()
        {
            return ProductName;
        }

        public override bool Validate()
        {
            var isvalid = true;
            if(string.IsNullOrWhiteSpace(ProductName)) isvalid = false;
            if(CurrentPrice == null) isvalid = false;

            return isvalid;
        }
    }
}
