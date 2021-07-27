using System.Collections.Generic;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Models;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public interface IUserRepository
    {
        // method for Displaying Menu Items
        List<Menu> GetMenuItems();

        // Method for Fetching Menu Item by Menu Name
        Menu GetMenuItem(string menuName);

        // Method for Fetching Customer Details by CustomerId
        List<CustomerViewModel> GetCustomer(int customerId);

        // Method for Fetching Payment Deatils by OrderId
        string GetPaymentStatus(int orderId);  

        // Method for Fetching Order Details by OrderId
        OrderItem GetOrderItem(int orderId);

        // Method for Updating Order by OrderId
        Orders GetOrder(int orderId);
        
    }
}
