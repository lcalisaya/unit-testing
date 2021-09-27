using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMSTestIntro;

namespace Tests
{
    [TestClass]
    public class CollectionSampleTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //Arrange: I prepare input and output variables 
            Customer[] customers = new Customer[2] { new Customer { FirstName = "Patricia", LastName = "Suarez"},
                                                     new Customer { FirstName = "Agostina", LastName = "Fernandez" } };
            int index = 1;
            Customer expectedCustomer = customers[1];

            //Act: Running the method
            Customer actualCustomer = CollectionsSample.GetCustomer(customers, index);

            //Assert: I find out if the result is the expected
            Assert.IsInstanceOfType(actualCustomer, typeof(Customer));
            Assert.AreEqual(expectedCustomer, actualCustomer);

        }
    }
}
