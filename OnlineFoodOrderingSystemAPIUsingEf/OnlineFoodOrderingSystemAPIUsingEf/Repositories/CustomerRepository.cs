using System.Linq;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private FoodOrderingContext context = null;
        public CustomerRepository(FoodOrderingContext context)
        {
            this.context = context;
        }
        //Add Customer
        public void AddCustomer(Customer customer)
        {
            context.Add(customer);
            context.SaveChanges();
        }
        
        // Add Order Item
        public void AddOrderItem(OrderItem orderItem)
        {
            
            int menuId = orderItem.MenuId;
            int price = ComputeTotal(menuId);
            int noOfServing = orderItem.NoOfServing;
            int totalAmount = (noOfServing*price);
            orderItem.Total = totalAmount;
            orderItem.Amount = price;
            context.Add(orderItem);
            context.SaveChanges();
        }
        public int ComputeTotal(int menuId)
        {
            Menu menu = context.Menu.SingleOrDefault(i => i.MenuId == menuId);
            return menu.Price;
        }
        //Place Order
        public void PlaceOrder(Orders order)
        {
            context.Add(order);
            context.SaveChanges();
        }

        //public void CalculateTotal(int noOfServing, int menuid)
        //{
        //    int totalAmount = ((int)(orderItem.NoOfServing * menu.Price));
        //}



        //Update Order 
        public void ModifyOrder(Orders order)
        {           
            context.Orderss.Update(order);
            context.SaveChanges();
        }

        //Cancel Order By Order Id
        public void CancelOrder(int orderId)
        {
            Orders order = context.Orderss.SingleOrDefault(i => i.OrderId == orderId);
            context.Remove(order);
            context.SaveChanges();
        }

        //Track Order Status By Order Id
        public string TrackOrderStatus(int orderId)
        {
            Orders orders = context.Orderss.SingleOrDefault(i => i.OrderId == orderId);
            return " Status: "+orders.OrderStatus;
        }

        //Make Payment
        public void MakePayment(Payment payment)
        {
            context.Add(payment);
            context.SaveChanges();
        }
       
        
    }
}


















//using System.Collections.Generic;
////Get Menu Items
//public List<Menu> GetMenuItems()
//{
//    return context.Menu.ToList();
//}
////Get Menu Item By Menu Name
//public Menu GetMenuItem(string menuName)
//{
//    Menu menu = context.Menu.SingleOrDefault(i => i.MenuName == menuName);
//    return menu;
//}