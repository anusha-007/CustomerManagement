using System;

namespace CustomerManagement
{
    public class ProductRepository
    {
        
         public Product Retrieve(int productId)
        {
           var product = new Product(productId);

           if( productId == 1 )
           {
               product.ProductName = "moto g40 fusion mobile";
               product.ProductDescription = "ram 6gb, storage 128gb";
               product.currentPrice = 16000;

           }

           Object obj = new Object();
            Console.Write(obj.ToString());
            Console.Write(product.ToString());
           return product;

        }

      
        public bool Save(Product product)
        {
            var success =  true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                       //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
        
    }
}