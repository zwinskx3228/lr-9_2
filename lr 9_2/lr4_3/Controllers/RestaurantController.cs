using lr4_3.Models;
using lr4_3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lr4_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var r = _service.GetById(id);
            return r == null ? NotFound() : Ok(r);
        }

        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            var created = _service.Create(restaurant);
            return Ok(created);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _service.Delete(id) ? Ok() : NotFound();
        }
    }
}
