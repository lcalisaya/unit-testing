using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMSTestIntro;

namespace Tests
{
    [TestClass]
    public class CalcTests
    {
        [DataRow(5, 6,11)]
        [DataRow(15, -6, 9)]
        [DataRow(-13, 47, 34)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnValue(int a, int b, int expected) //A descriptive name
        {
            //Arrange: Setting and initializing variables
            //Variables now declared as parameters

            //Act : The method is used
            int actual = Calcs.Sum(a, b);

            //Assert: It will be validated that the result is the expected
            Assert.AreEqual(expected, actual);
        }
    }
}
