using OnlineFoodOrderingSystemAPIUsingEf.Entities;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public interface ICustomerRepository
    {
        //Method for Posting New Customer
        public void AddCustomer(Customer customer);
        
        //Method for Adding Order Item
        public void AddOrderItem(OrderItem orderItem);

        //Method for Upadting Customer Details
        public void UpdateCustomer(Customer customer);

        //Method to Deleting Customer
        public void DeleteCustomer(int customerId);

        //Method for Placing Order
        public void PlaceOrder(Orders order);

        //Method for Updating Order
        public void ModifyOrder(Orders order);

        //Method for Cancellation of Order by OrderId (In Admin)
        public void CancelOrder(int orderId);

        //Method for Tracking Status of Order by OrderId
        public string TrackOrderStatus(int orderId);

        // Method for Making Payment
        public void MakePayment(Payment payment);
    }
}
