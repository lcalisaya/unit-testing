using System;
using UnitTestingXUnitIntro;
using Xunit;

namespace EmailTests
{
    public class MailValidatorShould
    {
        //[Fact]
        //public void ValidateValidEmails()
        //{
        //    //Arrange
        //    var mailValidator = new MailValidator();
        //    string emailAddress = "maildeprueba@gmail.com";

        //    //Act
        //    bool isValid = mailValidator.IsValidEmail(emailAddress);

        //    //Assert
        //    Assert.True(isValid, $"{emailAddress} is not a valid address.");

        //}

        [Fact]
        public void InvalidateInvalidEmails()
        {
            //Arrange
            var mailValidator = new MailValidator();
            string emailAddress = "invalid@invalid.invalid";

            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);

            //Assert
            Assert.False(isValid);

        }

        [Theory]
        [InlineData("maildeprueba@gmail.com", true)]
        [InlineData("invalid@invalid.invalid", false)]
        public void ValidateValidEmails(string emailAddress, bool expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            bool actual = mailValidator.IsValidEmail(emailAddress);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
