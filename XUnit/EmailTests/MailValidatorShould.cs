using System;
using UnitTestingXUnitIntro;
using Xunit;

namespace EmailTests
{
    public class MailValidatorShould
    {
        [Fact]
        public void ValidateValidEmails()
        {
            //Arrange
            var mailValidator = new MailValidator();
            string emailAddress = "maildeprueba@gmail.com";

            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);

            //Assert
            Assert.True(isValid, $"{emailAddress} is not a valid address.");

        }
    }
}
