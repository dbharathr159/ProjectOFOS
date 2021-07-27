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

        // Method for Updating Order By OrderId
        void UpdateOrderStatus(Orders order);

        //Method for Getting  MenuItems By MenuId
        public List<Menu> GetMenu(int menuId);
    }
}

