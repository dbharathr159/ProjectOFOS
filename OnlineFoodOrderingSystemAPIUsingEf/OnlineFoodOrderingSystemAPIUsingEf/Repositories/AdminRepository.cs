using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Models;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private FoodOrderingContext context = null;
        public AdminRepository(FoodOrderingContext context)
        {
            this.context = context;
        }

        //Add Menu Item
        public void AddMenuItem(Menu menu)
        {
            context.Add(menu);
            context.SaveChanges();
        }

        //Update Menu Item
        public void UpdateMenuItem(Menu menu)
        {            
            context.Update(menu);
            context.SaveChanges();
        }

        // Delete MenuItem by MenuId

        public void DeleteMenuItem(int menuId)
        {
            Menu menu = context.Menu.SingleOrDefault(i => i.MenuId == menuId);
            context.Remove(menu);
            context.SaveChanges();
        }
        
        // Get Menu Item  Details by MenuId -- Implemented StoredProcedure       
        public List<Menu> GetMenu(int menuId)
        {
            List<Menu> menu = context.Menu.FromSqlRaw("sp_GetMenuByMenuId {0}", menuId).ToList();
            return menu;
        }
        
        // Update Order Status
        public void UpdateOrderStatus(Orders order)
        {            
            context.Orderss.Update(order);
            context.SaveChanges();
        }

        //Get Customer Details by CustomerId
        public List<CustomerViewModel> GetCustomer(int customerId)
        {
            var list = context.Customers.Where(i => i.CustomerId == customerId).Select(c => new CustomerViewModel()
            { FirstName = c.FirstName, LastName = c.LastName, Mobile = c.Mobile, Email = c.Email, DeliveryAddress = c.DeliveryAddress }).ToList();
            return list;
        }

    }
}

