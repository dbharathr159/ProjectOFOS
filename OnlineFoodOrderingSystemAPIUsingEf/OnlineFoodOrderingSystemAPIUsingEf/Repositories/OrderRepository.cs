using System.Collections.Generic;
using System.Linq;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Models;

namespace OnlineFoodOrderingSystemAPIUsingEf.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private FoodOrderingContext context = null;
        public OrderRepository(FoodOrderingContext context)
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

        //Place Order
        public void PlaceOrder(Orders order)
        {
            context.Add(order);
            context.SaveChanges();
        }

        // Add Order Item
        public void AddOrderItem(OrderItem orderItem)
        {
            //Calculating TotalAmount
            int menuId = orderItem.MenuId;
            int price = ComputeTotal(menuId);
            int noOfServing = orderItem.NoOfServing;
            int totalAmount = (noOfServing * price);
            orderItem.Total = totalAmount;
            orderItem.Amount = price;
            context.Add(orderItem);
            context.SaveChanges();
        }

        //Get MenuItem Price By MenuId
        public int ComputeTotal(int menuId)
        {
            Menu menu = context.Menu.SingleOrDefault(i => i.MenuId == menuId);
            return menu.Price;
        }

        //Update Order 
        public void ModifyOrder(Orders order)
        {
            context.Orderss.Update(order);
            context.SaveChanges();
        }

        //Cancel Order By OrderId
        public void CancelOrder(int orderId)
        {
            Orders order = context.Orderss.SingleOrDefault(i => i.OrderId == orderId);
            context.Remove(order);
            context.SaveChanges();
        }

        //Track Order Status By OrderId
        public string TrackOrderStatus(int orderId)
        {
            Orders orders = context.Orderss.SingleOrDefault(i => i.OrderId == orderId);
            return " Status: " + orders.OrderStatus;
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

    }
}
