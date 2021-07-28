using System.Collections.Generic;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Models;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public interface IOrderRepository
    {
        // method for Displaying Menu Items
        List<Menu> GetMenuItems();

        // Method for Fetching Menu Item by Menu Name
        Menu GetMenuItem(string menuName);

        //Method for Placing Order
        public void PlaceOrder(Orders order);

        //Method for Adding Order Item
        public void AddOrderItem(OrderItem orderItem);

        //Method for Updating Order
        public void ModifyOrder(Orders order);

        //Method for Cancellation of Order by OrderId (In Admin)
        public void CancelOrder(int orderId);

        //Method for Tracking Status of Order by OrderId
        public string TrackOrderStatus(int orderId);  

        // Method for Fetching Order Details by OrderId
        OrderItem GetOrderItem(int orderId);

        // Method for Updating Order by OrderId
        Orders GetOrder(int orderId);
        
    }
}
