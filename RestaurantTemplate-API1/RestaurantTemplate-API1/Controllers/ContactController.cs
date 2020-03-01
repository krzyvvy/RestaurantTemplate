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
    public class ContactController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(ContactInformation contactInformation)
        {
            await _service.AddContact(contactInformation);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            var result = await _service.GetContacts();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
           var result = await _service.GetContact(id);
           return Ok(result); 
        }

        [HttpPut]
        public async Task<IActionResult> EditContact(ContactInformation contactInformation)
        {
            await _service.EditContact(contactInformation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _service.DeleteContact(id);
            return Ok();
        }
    }
}