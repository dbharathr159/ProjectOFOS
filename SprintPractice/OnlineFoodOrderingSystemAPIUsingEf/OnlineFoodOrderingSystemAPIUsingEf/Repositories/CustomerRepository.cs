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
            //Calculating TotalAmount
            int menuId = orderItem.MenuId;
            int price = ComputeTotal(menuId);
            int noOfServing = orderItem.NoOfServing;
            int totalAmount = (noOfServing*price);
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

        //Place Order
        public void PlaceOrder(Orders order)
        {
            context.Add(order);
            context.SaveChanges();
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
            return " Status: "+orders.OrderStatus;
        }

        //Make Payment
        public void MakePayment(Payment payment)
        {
            context.Add(payment);
            context.SaveChanges();
        }

        //Update Customer Details
        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        //Delete Customer
        public void DeleteCustomer(int customerId)
        {
            Customer customer = context.Customers.SingleOrDefault(i => i.CustomerId == customerId);
            context.Remove(customer);
            context.SaveChanges();
        }
    }
}

