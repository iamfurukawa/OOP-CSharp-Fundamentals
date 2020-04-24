using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1);
            expected.EmailAddress = "harrypote@gmail.com";
            expected.FirstName = "Harry";
            expected.LastName = "Potter";

            Assert.AreEqual(expected.CustomerId, customerRepository.Retrieve(1).CustomerId);
            Assert.AreEqual(expected.EmailAddress, customerRepository.Retrieve(1).EmailAddress);
            Assert.AreEqual(expected.FirstName, customerRepository.Retrieve(1).FirstName);
            Assert.AreEqual(expected.LastName, customerRepository.Retrieve(1).LastName);
        }
    }
}
