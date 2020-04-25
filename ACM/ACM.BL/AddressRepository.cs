using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public AddressRepository()
        {

        }
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }
        /// <summary>
        /// Retrieve all address from a customer.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
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

        public bool Save(Address address)
        {
            return true;
        }
    }
}
