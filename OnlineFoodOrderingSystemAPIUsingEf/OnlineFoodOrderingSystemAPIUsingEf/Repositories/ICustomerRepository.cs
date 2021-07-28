using OnlineFoodOrderingSystemAPIUsingEf.Entities;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public interface ICustomerRepository
    {
        //Method for Posting New Customer
        public void AddCustomer(Customer customer);

        //Method for Upadting Customer Details
        public void UpdateCustomer(Customer customer);

        //Method to Deleting Customer
        public void DeleteCustomer(int customerId);

        // Method for Making Payment
        public void MakePayment(Payment payment);

        // Method for Fetching Payment Deatils by OrderId
        string GetPaymentStatus(int orderId);
    }
}
