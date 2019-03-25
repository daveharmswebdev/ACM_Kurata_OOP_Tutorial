using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// retrieves a collection of products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        /// <summary>
        /// Retrieves a single product by product ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Bacon ipsum dolor amet beef ribs pork loin cow drumstick cupim frankfurter landjaeger pork chop meatball bresaola fatback chuck. Ham tail turkey jerky biltong rump frankfurter shoulder. Beef ribs venison corned beef chuck. Burgdoggen tongue pork loin meatball turducken landjaeger.";
                product.CurrentPrice = 19.99M;
            }

            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
