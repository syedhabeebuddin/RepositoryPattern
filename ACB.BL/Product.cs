using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
                
        }

        public Product(int productId)
        {
            this.ProductId = productId;
                
        }
        public decimal? CusrrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;

        }

        public override bool Validate()
        {
            return true;
        }
    }
}
