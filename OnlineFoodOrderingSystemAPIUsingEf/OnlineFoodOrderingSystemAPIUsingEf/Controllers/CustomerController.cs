using Microsoft.AspNetCore.Mvc;
using System;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Repositories;

namespace OnlineFoodOrderingSystemAPIUsingEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {

            _repository = repository;
        }

        //Add customer
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                _repository.AddCustomer(customer);
                return Ok("Customer Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Place Order
        [HttpPost]
        [Route("PlaceOrder")]
        public IActionResult PlaceOrder(Orders order)
        {
            try
            {
                _repository.PlaceOrder(order);
                return Ok("Order Placed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Add Order Item
        [HttpPost]
        [Route("AddOrderItem")]
        public IActionResult AddOrderItem(OrderItem orderItem)
        {
            try
            {
                _repository.AddOrderItem(orderItem);
                return Ok("OrderItem Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Make Payment By Orderid
        [HttpPost]
        [Route("MakePayment")]
        public IActionResult MakePayment(Payment payment)
        {
            try
            {
                _repository.MakePayment(payment);
                return Ok("payment Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        //TrackOrderStatusByOrderid
        [HttpGet]
        [Route("TrackOrderStatus/{orderId}")]
        public IActionResult TrackOrderStatus(int orderId)
        {
            string orderStatus = _repository.TrackOrderStatus(orderId);
            if (orderStatus != null)
            {
                return Ok(orderStatus);
            }
            else
            {
                return BadRequest("Invalid OrderId");
            }
        }

        //ModifyOrder
        [HttpPut]
        [Route("ModifyOrder")]
        public IActionResult ModifyOrder(Orders order)
        {
            try
            {
                _repository.ModifyOrder(order);
                return Ok("Order Modified");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Cancel Order by Order Id
        [HttpDelete]
        [Route("CancelOrder/{orderId}")]
        public IActionResult CancelOrder(int orderId)
        {
            try
            {
                _repository.CancelOrder(orderId);
                return Ok("Order Cancelled");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
                    

    }
}














//using System.Collections.Generic;

////Menu GetMenuitems
//[HttpGet]
//[Route("GetMenuItem")]
//public List<Menu> GetMenuItems()
//{
//    return _repository.GetMenuItems();
//}
////Get Menuitem By MenuName
//[HttpGet]
//[Route("GetMenuItem/{menuName}")]
//public IActionResult GetMenuItem(string menuName)
//{
//    Menu menu = _repository.GetMenuItem(menuName);
//    if (menu != null)
//    {
//        return Ok(menu);
//    }
//    else
//    {
//        return NotFound("Invalid Menu");
//    }

//}