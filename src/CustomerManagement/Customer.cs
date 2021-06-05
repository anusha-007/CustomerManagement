using System;
using System.Collections.Generic;

namespace CustomerManagement
{
    public class Customer
    {
         public Customer(): this(0)   // this default constructor TAKING addresslist from parameterized constructor 
        {
            
        }
        public Customer( int customerId )
        {
            CustomerId = customerId; 
			AddressList = new List<Address>();      
        }

		public  List<Address> AddressList{
 			get;
			set;
        }
        public int CustomerId{ get; private set;}
       
        public string EmailAddress{ get; set;}
        public int CustomerType  { get; set; }

        public string FullName
        {
            get
            {
               string fullName = FirstName;

              if( !string.IsNullOrWhiteSpace(LastName))
              {
                  if( !string.IsNullOrWhiteSpace(fullName))
                  {
                      fullName += ", ";
                  }
                  fullName += LastName;
              }
              return fullName;
            }
       
        }
        public string LastName{ get; set;}

        private string _firstName;
        public string  FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
 

       

        public bool Validate()
        {
            var isValid = true;

            if( string.IsNullOrWhiteSpace(FirstName) ) isValid = false;
            if( string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

       
    }
}