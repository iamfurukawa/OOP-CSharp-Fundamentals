using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {

        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerType { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            if (OrderDate == null) return false;

            return true;
        }
    }
}
