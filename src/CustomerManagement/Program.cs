using System;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var customer = new Customer
            {
                FirstName = "anusha",
                LastName = "ramadugu",
            };

            var customerFullName = customer.FullName;
            Console.WriteLine(customerFullName);

            var res = customer.Validate();
            System.Console.WriteLine(res);


            var adrRepo = new AddressRepository();
            var ans = adrRepo.Retrieve(1);
            Console.WriteLine( ans.City);

            var productRepo = new ProductRepository();
            var a = new Object();
            
           productRepo.Retrieve(1);

           // var handler = new StringHandler();
           // handler.InsertSpaces("AnushaRamadugu");
        }

    }
}
