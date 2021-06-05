using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Order
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
			OrderItems = new List<OrderItem>();

        }

        public int CustomerId {get; set;}
        public DateTimeOffset OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems {get; set;}
        public int ShippingAddressId {get;set;}

        public bool Validate()
        {
            bool isValid = true;

            if( OrderDate == null ) isValid = false;
            return isValid;

        }

       
    }
}