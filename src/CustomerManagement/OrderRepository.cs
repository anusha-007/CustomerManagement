namespace CustomerManagement
{
    public class OrderRepository
    {
         public Order Retrieve(int orderId)
        {
          var order = new Order(orderId);
          if( orderId == 1 )
          {
            //   order.OrderDate=12;

          }

          return order;

        }

        public bool Save()
        {
            return true;

        }
    }
}