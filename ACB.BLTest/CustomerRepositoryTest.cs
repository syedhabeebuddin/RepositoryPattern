using ACB.BL;
using ACB.BL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "first",
                LastName = "last",
                Email= "aa@g.com"

            };

            var actual = customerRepo.Retrieve(1);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);            
        }
    }
}
