using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address();
            if (addressId == 1) {
                address.AddressType = 1;
                address.StreetLine1 = "Street1";
                address.StreetLine2 = "Street2";
                address.City = "Ahmedabad";
                address.State = "Gujarat";
                address.Country = "India";
                address.PostalCode = "123456";
            }
            return address; 
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var AddressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Street1",
                StreetLine2 = "Street2",
                City = "Ahmedabad",
                State = "Gujarat",
                Country = "India",
                PostalCode = "123456"
            };
            AddressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Street11",
                StreetLine2 = "Street22",
                City = "Ahmedabad1",
                State = "Gujarat1",
                Country = "India1",
                PostalCode = "654321"
            };
            AddressList.Add(address);

            return AddressList;

        }

    }
}
