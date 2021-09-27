namespace UnitTestingMSTestIntro
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CollectionsSample
    {
        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }
    }
}
