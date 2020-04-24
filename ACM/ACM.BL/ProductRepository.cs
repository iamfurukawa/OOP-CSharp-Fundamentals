using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public ProductRepository()
        {

        }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Cerveja Amanteigada";
                product.ProductDescription = "A famosa Cerveja Amanteigada";
                product.CurrentPrice = 30.00M;
            }

            return product;
        }

        /// <summary>
        /// Save the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
