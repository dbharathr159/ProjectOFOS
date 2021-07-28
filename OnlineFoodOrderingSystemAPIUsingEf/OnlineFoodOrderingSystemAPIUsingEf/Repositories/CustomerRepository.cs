using System.Collections.Generic;
using System.Linq;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Models;
using OnlineFoodOrderingSystemAPIUsingEf.Repositories;

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

        //Get Payment Details by OrderId
        public string GetPaymentStatus(int orderId)
        {
            Payment payment = context.Payments.SingleOrDefault(i => i.OrderId == orderId);
            return "Payment Status: " + payment.PaymentStatus;
        }
    }
}

