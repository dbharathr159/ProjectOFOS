using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Repositories;
using OnlineFoodOrderingSystemAPIUsingEf.Models;

namespace OnlineFoodOrderingSystemAPIUsingEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;

        }

        //Get Menu Items
        [HttpGet]
        [Route("GetMenu")]
        public List<Menu> GetMenuItems()
        {
            return _repository.GetMenuItems();
        }

        // Get Order By Order Id
        [HttpGet]
        [Route("GetOrder/{orderId}")]
        public IActionResult GetOrder(int orderId)
        {
            Orders order = _repository.GetOrder(orderId);
            if (order != null)
            {
                return Ok(order);
            }
            else
            {
                return NotFound("Invalid Order");
            }

        }

        // Get Orderitem by orderitemid
        [HttpGet]
        [Route("GetOrderItem/{orderId}")]
        public IActionResult GetOrderItem(int orderId)
        {
            OrderItem orderItem = _repository.GetOrderItem(orderId);
            if (orderItem != null)
            {
                return Ok(orderItem);
            }
            else
            {
                return NotFound("Invalid Orderitem");
            }
        }
        // Get Customer By Customer Id
        [HttpGet]
        [Route("GetCustomer/{customerId}")]
        public IActionResult GetCustomer(int customerId)
        {
            List<CustomerViewModel> customer = _repository.GetCustomer(customerId);
            if (customer != null)
            {
                return Ok(customer);
            }
            else
            {
                return NotFound("Invalid Customer");
            }
        }

        // Get Payment By Order Id
        [HttpGet]
        [Route("GetPaymentStatus/{orderId}")]
        public IActionResult GetPaymentStatus(int orderId)
        {
            string payment = _repository.GetPaymentStatus(orderId);
            if (payment != null)
            {
                return Ok(payment);
            }
            else
            {
                return NotFound("Invalid Payment");
            }
        }

        //Get Menuitem By MenuName
        [HttpGet]
        [Route("GetMenuItem/{menuName}")]
        public IActionResult GetMenuItem(string menuName)
        {
            Menu menu = _repository.GetMenuItem(menuName);
            if (menu != null)
            {
                return Ok(menu);
            }
            else
            {
                return NotFound("Invalid Menu");
            }

        }
    }
}
