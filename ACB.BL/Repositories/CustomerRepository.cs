using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL.Repositories
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
                
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.LastName = "last";
                customer.FirstName = "first";
                customer.Email = "aa@g.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList<Address>();

            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }

    
}
