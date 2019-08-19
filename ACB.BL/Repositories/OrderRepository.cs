using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,7,27,14,39,0,new TimeSpan(7,0,0));

            }

            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
