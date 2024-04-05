using BooksManagement;
using System;


namespace BooksManagement_xUnitTest
{
    public class UnitTest1
    {
        // Customer
        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("valid.email+alias@example.com", true)]
        [InlineData("invalid-email@example", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("noatsign.com", false)]
        [InlineData("@noLocalPart.com", false)]
        [InlineData("local@.com", false)]
        [InlineData("local@domain.com.a", true)]
        [InlineData("email@123.123.123.123", true)]
        [InlineData("email@[123.123.123.123]", true)]
        [InlineData("\"email\"@example.com", true)]

        public void IsValidEmailTest(string email, bool expected)
        {
            bool result = Customer.IsValidEmail(email);
            Assert.Equal(expected, result);
        }
    }
}