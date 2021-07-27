using Microsoft.AspNetCore.Mvc;
using System;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Repositories;

namespace OnlineFoodOrderingSystemAPIUsingEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminRepository _repository;
        public AdminController(IAdminRepository repository)
        {
            _repository = repository;

        }

        //Add Menu Item
        [HttpPost]
        [Route("AddMenu")]
        public IActionResult AddMenuItem(Menu menu)
        {
            try
            {
                _repository.AddMenuItem(menu);
                return Ok("Item Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //  Update Order Status
        [HttpPut]
        [Route("UpdateOrderStatus")]
        public IActionResult UpdateOrderStatus(Orders order)
        {
            try
            {
                _repository.UpdateOrderStatus(order);
                return Ok("Order Modified");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        //Update Menu Item
        [HttpPut]
        [Route("UpdateMenuItem")]
        public IActionResult UpdateMenuItem(Menu menu)
        {
            try
            {
                _repository.UpdateMenuItem(menu);
                return Ok("Item Update");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        //Delete Menu By Menu Id
        [HttpDelete]
        [Route("DeleteMenu/{menuId}")]
        public IActionResult DeleteMenuItem(int menuId)
        {
            try
            {
                _repository.DeleteMenuItem(menuId);
                return Ok("Item Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
                        
                               
    }
}














//using OnlineFoodOrderingSystemAPIUsingEf.Models;
//using System.Collections.Generic;

// Get Menu by MenuId
//[HttpGet]
//[Route("GetMenu/{menuId}")]
//public IActionResult GetMenu(int menuId)
//{
//    List<Menu> menu = _repository.GetMenu(menuId);

//    if (menu != null)
//    {
//        return Ok(menu);
//    }
//    else
//    {
//        return NotFound("Invalid Menu");
//    }
//}
// Get Customers
//[HttpGet]
//[Route("GetCustomers")]
//public List<CustomerViewModel> GetCustomers()
//{
//    return _repository.GetCustomers();
//}

//Get Menu Items
//[HttpGet]
//[Route("GetMenu")]
//public List<Menu> GetMenuItems()
//{
//    return _repository.GetMenuItems();
//}

// Get Order By Order Id
//[HttpGet]
//[Route("GetOrder/{orderId}")]
//public IActionResult GetOrder(int orderId)
//{
//    Orders order = _repository.GetOrder(orderId);
//    if (order != null)
//    {
//        return Ok(order);
//    }
//    else
//    {
//        return NotFound("Invalid Order");
//    }

//}
// Get Orderitem by orderitemid
//[HttpGet]
//[Route("GetOrderItem/{orderId}")]
//public IActionResult GetOrderItem(int orderId)
//{
//    OrderItem orderItem = _repository.GetOrderItem(orderId);
//    if (orderItem != null)
//    {
//        return Ok(orderItem);
//    }
//    else
//    {
//        return NotFound("Invalid Orderitem");
//    }
//}


// Get Customer By Customer Id
//[HttpGet]
//[Route("GetCustomer/{customerId}")]
//public IActionResult GetCustomer(int customerId)
//{
//    List<CustomerViewModel> customer = _repository.GetCustomer(customerId);
//    if (customer != null)
//    {
//        return Ok(customer);
//    }
//    else
//    {
//        return NotFound("Invalid Customer");
//    }
//}

// Get Payment By Order Id
//[HttpGet]
//[Route("GetPaymentDetails/{orderId}")]
//public IActionResult GetPayment(int orderId)
//{
//    Payment payment = _repository.GetPayment(orderId);
//    if (payment != null)
//    {
//        return Ok(payment);
//    }
//    else
//    {
//        return NotFound("Invalid Payment");
//    }
//}