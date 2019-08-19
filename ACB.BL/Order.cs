using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL
{
    public class Order
    {
        public Order():this(0)
        {
                
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
            this.OrderItemsList = new List<OrderItem>();
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItemsList { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();

        }

        public List<Order> Retrieve()
        {
            return new List<Order>();

        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            return true;
        }
    }
}
