using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;


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
            //TotalAmount(int noOfServings, decimal price)
            context.SaveChanges();
        }
        //Update Menu Item by Menu Id
        public void UpdateMenuItem(Menu menu)
        {            
            context.Update(menu);
            context.SaveChanges();
        }
        // Delete Item Menu by Menu Id

        public void DeleteMenuItem(int menuId)
        {
            Menu menu = context.Menu.SingleOrDefault(i => i.MenuId == menuId);
            context.Remove(menu);
            context.SaveChanges();
        }
        
        // Get Menu Item  Details by Menu Id        
        public List<Menu> GetMenu(int menuId)
        {
            List<Menu> menu = context.Menu.FromSqlRaw("sp_GetMenuByMenuId {0}", menuId).ToList();
            return menu;
        }
        
        // Updating Order Status
        public void UpdateOrderStatus(Orders order)
        {            
            context.Orderss.Update(order);
            context.SaveChanges();
        }
       

    }
}












//using OnlineFoodOrderingSystemAPIUsingEf.Models;
//Get Menu Items
//public List<Menu> GetMenuItems()
//{
//    return context.Menu.ToList();
//}
//Get Order Item by Order Id
//public OrderItem GetOrderItem(int orderId)
//{
//    OrderItem orderItem = context.OrderItems.SingleOrDefault(i => i.OrderId == orderId);
//    return orderItem;
//}
////Get Order Details By Order Id
//public Orders GetOrder(int orderId)
//{
//    Orders order = context.Orderss.SingleOrDefault(i => i.OrderId == orderId);
//    return order;
//}


//Get Customer Details by Customer Id
//public List<CustomerViewModel> GetCustomer(int customerId)
//{
//    var list=context.Customers.Where(i=>i.CustomerId==customerId).Select(c => new CustomerViewModel() 
//    { FirstName = c.FirstName, LastName = c.LastName, Mobile = c.Mobile, Email = c.Email, DeliveryAddress=c.DeliveryAddress }).ToList();
//    return list;
//  //new CustomerViewModel() { FirstName = c.FirstName, LasttName = c.LastName, Mobile = c.Mobile, Email = c.Email }
//}
////Get Payment Details by Order Id
//public Payment GetPayment(int orderId)
//{
//    Payment payment = context.Payments.SingleOrDefault(i => i.OrderId == orderId);
//    return payment;
//}
