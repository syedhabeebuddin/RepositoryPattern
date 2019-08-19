using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL.Repositories
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "aa";
                address.StreetLine2 = "xxx";
                address.City = "Hyderabad";
                address.State = "TS";
                address.PostalCode = "1122";
                address.Country = "India";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address1 = new Address(1) { AddressType = 1, City = "Hyd", Country = "India", PostalCode = "aa11", State = "TS", StreetLine1 = "ss", StreetLine2 = "ss2" };
            Address address2 = new Address(2) { AddressType = 2, City = "Hyd", Country = "India", PostalCode = "aa11", State = "TS", StreetLine1 = "ss", StreetLine2 = "ss2" };

            addressList.Add(address1);
            addressList.Add(address2);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
