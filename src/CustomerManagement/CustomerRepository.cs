using System.Collections.Generic;
using System.Linq;

namespace CustomerManagement
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "ramaduguanusha123@gmail.com";
                customer.FirstName = "anusha";
                customer.LastName = "ramadugu";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }


        public bool Save()
        {
            return true;
        }
    }
}