using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;
using OnlineFoodOrderingSystemAPIUsingEf.Repositories;
using System;

namespace OnlineFoodOrderingSystemAPIUsingEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderRepository _repository;
        public OrderController(IOrderRepository repository)
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

        //Modify Order
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

        //Track OrderStatus By OrderId
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

        //Cancel Order By OrderId
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

        // Get Order By OrderId
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

        // Get Orderitem by OrderId
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

    }
}
