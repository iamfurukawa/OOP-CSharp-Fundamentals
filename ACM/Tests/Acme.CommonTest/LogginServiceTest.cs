using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1);
            customer.FirstName = "Harry";
            customer.LastName = "Potter";

            var product = new Product(2);
            product.ProductName = "Cerveja Amanteigada";
            product.ProductDescription = "A famosa Cerveja Amanteigada";
            product.CurrentPrice = 30.00M;

            changedItems.Add(product);
            changedItems.Add(customer);

            LogginService.WriteToFile(changedItems);
        }
    }
}
