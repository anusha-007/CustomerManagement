using System;
using System.Collections.Generic;
using Xunit;

namespace CustomerManagement.tests
{
    public class CustomerTests
    {
        [Fact]
        public void Test1()
        {
            var customer = new Customer()
            {
                FirstName = "helo",
                LastName = "anusha"
            };

            var expected = "helo, anusha";
            var actual = customer.FullName;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestCustomerRepo()
        {
            var expected = new Customer(1);
            expected.FirstName = "anusha";
            expected.LastName = "ramadugu";
            var customerRepo = new CustomerRepository();

            var actual = customerRepo.Retrieve(1);

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

        }

        [Fact]
        public void TestProductRepo()
        {
            var expected = new Product(1);
            expected.currentPrice = 16000;
            expected.ProductDescription = "ram 6gb, storage 128gb";

            var productRepo = new ProductRepository();
            var actual = productRepo.Retrieve(1);

            Assert.Equal(expected.currentPrice, actual.currentPrice);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);


        }


        [Fact]
        public void TestAddressRepo()
        {
            var address = new Address(1)
            {
                City = "krp",
                State = "Telangana"
            };


            var addrRepo = new AddressRepository();
            var expected = addrRepo.Retrieve(1);

            Assert.Equal(expected.City, address.City);
        }
        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "ramaduguanusha123@gmail.com",
                FirstName = "anusha",
                LastName = "ramadugu",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        City = "jmkt",
                        State = "jammikunta"
                    },
                    new Address()
                    {
                        City = "venk",
                        State = "karimanagar"
                    }
                }
            };
            var actual = customerRepository.Retrieve(1);
            Assert.Equal(expected.CustomerId,actual.CustomerId);
            Assert.Equal(expected.FirstName,actual.FirstName);
            Assert.Equal(expected.LastName,actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].City,actual.AddressList[i].City);
            }
        }
    
        [Fact]
        public void SaveTestValid()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                currentPrice = 18M,
                ProductDescription = "curtains",
                ProductName = "cotton",
                HasChanges = true
            };
            
            //act
            var actual = productRepository.Save(updatedProduct);
            
            Assert.Equal(true,actual);
        }
        [Fact]
        public void SaveTestMissingPrice()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                currentPrice = null,
                ProductDescription = "curtains",
                ProductName = "cotton",
                HasChanges = true
            };
            //act
            var actual = productRepository.Save(updatedProduct);
            
            //assert
            Assert.Equal(false, actual);
        }

        [Fact]
        public void InsertSpacesTest()
        {
            var source = "AnushaRamadugu";
            var expected = "Anusha Ramadugu";
            // var handler = new StringHandler();
            //
            // //act
            // var actual = handler.InsertSpaces(source);
            //assert
            //Assert.Equal(expected, actual);
        }
    }
}
