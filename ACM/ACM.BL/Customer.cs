using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Address HomeAddress;
        public Address WorkAddress;
        public string FullName
        {
            get
            {
                if(string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }
                
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }

                return LastName + ", " + FirstName;
            }
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (String.IsNullOrWhiteSpace(FirstName)) return false;
            if (String.IsNullOrWhiteSpace(LastName)) return false;

            return true;
        }

        
        public static int InstanceCount { get; set; }

    }
}
