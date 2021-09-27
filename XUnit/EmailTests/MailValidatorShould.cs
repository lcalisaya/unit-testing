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

        [Theory]
        [InlineData("maildeprueba@gmail.com", "INBOX")]
        [InlineData("invalid@invalid.donttrust.com", "SPAM")]
        [InlineData("invalid.com.@dodgy.com", "SPAM")]
        [InlineData("ejemplo@ejemplo.gob", "INBOX")]
        [InlineData("trydata@anothersample.com", "SPAM")]
        [InlineData("testinxuni@sample.com", "SPAM")]
        public void IdentifySpam(string emailAddress, string expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            string actual = mailValidator.IsSpam(emailAddress);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RaiseErrorWhenEmailIsEmpty()
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act

            //Assert
            Assert.Throws<EmailNotProvidedException>(() => mailValidator.IsValidEmail(null));

        }
    }
}
