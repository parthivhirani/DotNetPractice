using CSharpPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                email = "parthivhirani@gmail.com",
                firstName = "Parthiv",
                LastName = "Hirani",
                // composition relationship example
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Street1",
                        StreetLine2 = "Street2",
                        City = "Ahmedabad",
                        State = "Gujarat",
                        Country = "India",
                        PostalCode = "123456"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Street11",
                        StreetLine2 = "Street22",
                        City = "Ahmedabad1",
                        State = "Gujarat1",
                        Country = "India1",
                        PostalCode = "654321"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.customerId, actual.customerId);
            Assert.Equal(expected.email, actual.email);
            Assert.Equal(expected.firstName, actual.firstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for(int i=0; i<1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
