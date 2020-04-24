using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();

            var product = new Product(2);
            product.ProductName = "Cerveja Amanteigada";
            product.ProductDescription = "A famosa Cerveja Amanteigada";
            product.CurrentPrice = 30.00M;

            Assert.AreEqual(productRepository.Retrieve(2).ProductName, product.ProductName);
            Assert.AreEqual(productRepository.Retrieve(2).ProductDescription, product.ProductDescription);
            Assert.AreEqual(productRepository.Retrieve(2).CurrentPrice, product.CurrentPrice);
        }
    }
}
