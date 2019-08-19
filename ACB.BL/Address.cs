using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL
{
    public class Address
    {
        public Address()
        {
                
        }

        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public Address Retrieve(int addressId)
        {
            return new Address();
        }

        public bool Validate()
        {
            return true;
        }

        public bool Save()
        {
            return true;
        }
    }
}
