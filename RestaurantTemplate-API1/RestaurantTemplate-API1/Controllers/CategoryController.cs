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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInformation categoryInformation)
        {
            await _service.AddCategory(categoryInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _service.GetCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var result = await _service.GetCategory(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditCategory(CategoryInformation categoryInformation)
        {
            await _service.EditCategory(categoryInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _service.DeleteCategory(id);
            return Ok();
        }
    }
}