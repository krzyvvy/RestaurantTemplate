using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantTemplate_API1.Models.Information;
using RestaurantTemplate_API1.Services;

namespace RestaurantTemplate_API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishService _service;
        public DishesController(IDishService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddDish(DishInformation dishInformation)
        {
            await _service.AddDish(dishInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetDishes()
        {
            var result = await _service.GetDishes();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDish(int id)
        {
            var result = await _service.GetDish(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditDish(DishInformation dishInformation)
        {
            await _service.EditDish(dishInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDish(int id)
        {
            await _service.DeleteDish(id);
            return Ok();
        }
    }
}
