using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderRepository()
        {

        }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            if (!order.HasChanges || !order.IsValid) return false;

            if (order.IsNew)
            {
                //store
            }
            else
            {
                //update
            }

            return true;
        }
    }
}
