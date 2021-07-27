using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using System.Collections.Generic;


namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public interface IAdminRepository
    {
        // Method for Posting Menu Item
        public void AddMenuItem(Menu menu);

        // Method for Updating Menu Item
        public void UpdateMenuItem(Menu menu);

        // Method for Deleting Menu Item
        void DeleteMenuItem(int menuId);

        // Method for Updating Order by OrderId
        void UpdateOrderStatus(Orders order);

        public List<Menu> GetMenu(int menuId);
    }
}





















//
//using OnlineFoodOrderingSystemAPIUsingEf.Models;
//// Method for Displaying Menu Items (Repeated)
//List<Menu> GetMenuItems();
//// Method for Fetching Menu Item by MenuId (Repeated)
//List<Menu> GetMenu(int menuId);
//// 5 Method for Fetching Order Item Details by OrderId
//OrderItem GetOrderItem(int orderId);
////  4 Method for Fetching Order Details by OrderId 
//Orders GetOrder(int orderId);
// Method for Displaying Customers
//List<CustomerViewModel> GetCustomers();
//// 6 Method for Fetching Customer Details by CustomerId
//List<CustomerViewModel> GetCustomer(int customerId);
//// 7 Method for Fetching Payment Deatils by OrderId
//Payment GetPayment(int orderId);//11