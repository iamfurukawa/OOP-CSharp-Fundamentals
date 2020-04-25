using System;
using System.Collections.Generic;
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
            expected.AddressList = createAddressList();

            Assert.AreEqual(expected.CustomerId, customerRepository.Retrieve(1).CustomerId);
            Assert.AreEqual(expected.EmailAddress, customerRepository.Retrieve(1).EmailAddress);
            Assert.AreEqual(expected.FirstName, customerRepository.Retrieve(1).FirstName);
            Assert.AreEqual(expected.LastName, customerRepository.Retrieve(1).LastName);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, customerRepository.Retrieve(1).AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, customerRepository.Retrieve(1).AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, customerRepository.Retrieve(1).AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, customerRepository.Retrieve(1).AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, customerRepository.Retrieve(1).AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, customerRepository.Retrieve(1).AddressList[i].PostalCode);
            }
        }

        private List<Address> createAddressList()
        {
            var addressList = new List<Address>();

            Address address1 = new Address(1);
            address1.AddressType = 1;
            address1.StreetLine1 = "Bag End";
            address1.StreetLine2 = "Bagshot row";
            address1.City = "Hobbiton";
            address1.State = "Shire";
            address1.Country = "Middle Earth";
            address1.PostalCode = "144";

            Address address2 = new Address(2);
            address2.AddressType = 1;
            address2.StreetLine1 = "Green Dragon";
            address2.City = "Bywater";
            address2.State = "Shire";
            address2.Country = "Middle Earth";
            address2.PostalCode = "146";

            addressList.Add(address1);
            addressList.Add(address2);

            return addressList;
        }
    }
}
