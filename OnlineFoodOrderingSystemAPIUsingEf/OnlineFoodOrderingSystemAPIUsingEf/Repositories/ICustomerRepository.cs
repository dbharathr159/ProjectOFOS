using OnlineFoodOrderingSystemAPIUsingEf.Entities;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public interface ICustomerRepository
    {
        //Method for Posting Customer Details
        public void AddCustomer(Customer customer);
        
        //Method for Adding Order Item
        public void AddOrderItem(OrderItem orderItem);

        //Method for Placing Order
        public void PlaceOrder(Orders order);

        //Method for Updating Order(Delete)
        public void ModifyOrder(Orders order);

        //Method for Cancellation of Order by Order ID (In Admin)
        public void CancelOrder(int orderId);

        //  Method for Tracking Status of Order by OrderId
        public string TrackOrderStatus(int orderId);

        //  Method for Doing Payment
        public void MakePayment(Payment payment);
    }
}

















//using System.Collections.Generic;
//// 1 method for Displaying Menu Items
//List<Menu> GetMenuItems();
//// 2 Method for Fetching Menu Item by Menu Name
//Menu GetMenuItem(string menuName);