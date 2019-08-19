using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL.Repositories
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "sunflower";
                product.ProductDescription = "just desc";
                product.CusrrentPrice = 15.9m;

            }

            return product;
        }

        public bool Save(Product customer)
        {
            return true;
        }
    }
}
