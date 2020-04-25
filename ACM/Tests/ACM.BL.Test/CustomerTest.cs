using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Harry";
            customer.LastName = "Potter";

            string expected = "Potter, Harry";

            Assert.AreEqual(expected, customer.FullName);
        }
        
        [TestMethod]
        public void FirstNameEmpty()
        {
            Customer customer = new Customer();
            customer.FirstName = "Harry";

            string expected = "Harry";

            Assert.AreEqual(expected, customer.FullName);
        }

        [TestMethod]
        public void LastNameEmpty()
        {
            Customer customer = new Customer();
            customer.LastName = "Potter";

            string expected = "Potter";

            Assert.AreEqual(expected, customer.FullName);
        }

        [TestMethod]
        public void StaticTest()
        {
            Customer customer1 = new Customer();
            customer1.LastName = "Potter";
            Customer.InstanceCount++;

            Customer customer2 = new Customer();
            customer1.LastName = "Hermione";
            Customer.InstanceCount++;

            Customer customer3 = new Customer();
            customer1.LastName = "Rony";
            Customer.InstanceCount++;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer();
            customer.FirstName = "Harry";
            customer.LastName = "Potter";

            Assert.AreEqual(true, customer.Validate());
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            Customer customer = new Customer();
            customer.EmailAddress = "harrypote@gmail.com";

            Assert.AreEqual(false, customer.Validate());
        }
    }
}
