using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private Car _car;
        private IApiLogger _logger;
        private CarAccessories _accessories;
        public CarController(Car c, IApiLogger logger,CarAccessories ca, IAccessories accessories)
        {
            _car = c;
            _logger = logger;
            _logger.Log("CarController instance is created");

            _accessories = ca;
            _logger = logger;
            _logger.Log("CarAccessories instance is created");
                
        }

        [HttpGet("/drive")]
        public IActionResult Drive()
        {
            _logger.Log("Driving() api called successfully");
            return Ok("Driving at 100kmph");
        }

        [HttpGet("/accessories")]
        public IActionResult Accessories()
        {
            _logger.Log("CarAccessories() api called successfully");
            return Ok("Favorite Accessories");
        }
    }
}
