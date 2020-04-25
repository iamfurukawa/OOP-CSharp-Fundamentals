using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        private string productName;

        public Product()
        {

        }

        public Product(int productId)
        {

        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName {
            get
            {
                return productName.InsertSpaces();
            }
            set 
            { 
                productName = value; 
            }
        }

        /// <summary>
        /// Validate the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(ProductName)) return false;
            if (CurrentPrice == null) return false;

            return true;
        }
    }
}
