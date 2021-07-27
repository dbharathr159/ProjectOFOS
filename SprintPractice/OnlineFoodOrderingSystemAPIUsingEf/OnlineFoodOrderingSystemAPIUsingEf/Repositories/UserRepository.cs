using System.Collections.Generic;
using System.Linq;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Models;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public class UserRepository:IUserRepository
    {
        private FoodOrderingContext context = null;
        public UserRepository(FoodOrderingContext context)
        {
            this.context = context;
        }

        //Get MenuItems
        public List<Menu> GetMenuItems()
        {
            return context.Menu.ToList();
        }

        //Get MenuItem  Details by Menu Id        
        public Menu GetMenuItem(string menuName)
        {
            Menu menu = context.Menu.SingleOrDefault(i => i.MenuName == menuName);
            return menu;
        }

        //Get Order Item by OrderId
        public OrderItem GetOrderItem(int orderId)
        {
            OrderItem orderItem = context.OrderItems.SingleOrDefault(i => i.OrderId == orderId);
            return orderItem;
        }

        //Get Order Details By OrderId
        public Orders GetOrder(int orderId)
        {
            Orders order = context.Orderss.SingleOrDefault(i => i.OrderId == orderId);
            return order;
        }

        //Get Customer Details by CustomerId
        public List<CustomerViewModel> GetCustomer(int customerId)
        {
            var list = context.Customers.Where(i => i.CustomerId == customerId).Select(c => new CustomerViewModel()
            { FirstName = c.FirstName, LastName = c.LastName, Mobile = c.Mobile, Email = c.Email, DeliveryAddress = c.DeliveryAddress }).ToList();
            return list;
        }

        //Get Payment Details by OrderId
        public string GetPaymentStatus(int orderId)
        {
            Payment payment = context.Payments.SingleOrDefault(i => i.OrderId == orderId);
            return "Payment Status: "+payment.PaymentStatus;
        }
    }
}
