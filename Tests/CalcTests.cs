using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMSTestIntro;

namespace Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_ShouldCalcAndReturnValue() //A descriptive name
        {
            //Act: Setting and initializing variables
            int a = 5;
            int b = 6;
            int expected = 11;

            //Arrange: The method is used
            int actual = Calcs.Sum(a, b);

            //Assert: It will be validated that the result is the expected
            Assert.AreEqual(expected, actual);

            //"Equals" compares references
            //Assert.Equals(expected, actual);
        }
    }
}
