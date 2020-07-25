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
    }
}
