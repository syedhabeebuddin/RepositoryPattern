using System;
using ACB.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACB.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer();
            customer.LastName = "aaa";
            customer.FirstName = "bbb";

            string expectedValue = "aaa,bbb";
            string actualValue = customer.FullName;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FullNameTestInValid()
        {
            Customer customer = new Customer();
            customer.LastName = "aaa";
            customer.FirstName = "bbb";

            string expectedValue = "bbb,aaa";
            string actualValue = customer.FullName;

            Assert.AreNotEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void StaticTest()
        {
            var C1 = new Customer();
            C1.FirstName = "aaa";
            Customer.InstanceCount += 1;

            var C2 = new Customer();
            C2.FirstName = "bbb";
            Customer.InstanceCount += 1;

            var C3 = new Customer();
            C3.FirstName = "cccc";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);


        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer()
            {
                LastName = "aa",
                Email = "a@g.com"
            };

            var expected = true;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
