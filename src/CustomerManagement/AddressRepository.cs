using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class AddressRepository
    {
	    public Address Retrieve( int addressId )  // this retrieves single address only
        {
           var address = new Address(addressId);
           Console.Write("heloo");
             //Console.WriteLine(customerFullName);
			if( addressId == 1 )
              {
               
				 address.City = "krp";
				 address.State = "Telangana";
               } 
			
			return address;
       
        }

       public IEnumerable<Address> RetrieveByCustomerId( int customerId )
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
	           City = "jmkt",
            };
            addressList.Add(address);

            address = new Address(2)
            {
	           AddressType = 1,
	           City = "jammikunta",

            };
           addressList.Add(address);
			return addressList;

        }

        public bool Save()
         {
           return true;
          }
    }
}