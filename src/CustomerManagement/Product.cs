using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? currentPrice { get; set; }
        
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        public string _productName;

        public string ProductName
        {
            get
            {
               return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public override string ToString()
        {
            return ProductName;
        }


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (currentPrice == null) isValid = false;

            return isValid;
        }
    }
}