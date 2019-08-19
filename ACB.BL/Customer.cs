using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {
                
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        public List<Address> AddressList { get; set; }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email { get; set; }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }

        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(this.LastName))
                isValid = false;

            if (string.IsNullOrEmpty(Email))
                isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public override string ToString()
        {
            //return base.ToString();
            return this.FullName;
        }
    }
}
