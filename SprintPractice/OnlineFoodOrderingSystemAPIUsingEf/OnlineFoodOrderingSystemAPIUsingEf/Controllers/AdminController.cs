using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        
        //Delete Menu By MenuId
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

        // Get Menu by MenuId
        [HttpGet]
        [Route("GetMenu/{menuId}")]
        public IActionResult GetMenu(int menuId)
        {
            List<Menu> menu = _repository.GetMenu(menuId);

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

