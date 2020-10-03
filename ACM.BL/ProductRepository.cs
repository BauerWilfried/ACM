using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            var product = new Product(1)
            {
                ProductName = "Ring",
                Description = "the one ring",
                CurrentPrice = (decimal)12.3,
            };
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call save to db
                    }
                    else
                    {
                        //call update to db
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
