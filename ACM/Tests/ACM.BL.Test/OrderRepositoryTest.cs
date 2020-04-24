using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();

            var order = new Order(10);
            order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            Assert.AreEqual(order.OrderDate, orderRepository.Retrieve(10).OrderDate);
        }
    }
}
