using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName)
                && !string.IsNullOrWhiteSpace(Description)
                && CurrentPrice != null;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }
    }
}
