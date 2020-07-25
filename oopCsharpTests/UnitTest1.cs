using System;
using oopCsharp;
using Xunit;

namespace oopCsharpTests
{
    public class UnitTest1
    {
        [Fact]
        public void ExpectedName()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
            };
            string expected = "Bilbo";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rose";
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);
        }
        [Fact]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggings@gma.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);
         
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                EmailAddress = "fbaggings@gma.com"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);

        }
    }
}
