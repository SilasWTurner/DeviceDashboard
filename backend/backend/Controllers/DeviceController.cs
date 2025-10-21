using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly DeviceService _deviceService =  new DeviceService();
        
        // Endpoint for getting all devices
        [HttpGet]
        public ActionResult<IEnumerable<Device>> GetAll()
        {
            return Ok(_deviceService.GetAllDevices());
        }

        // Endpoint for getting specific device from id
        [HttpGet("{id}")]
        public ActionResult<Device> Get(int id)
        {
            var device = _deviceService.GetDevice(id);
            if (device == null) return NotFound();
            return Ok(device);
        }
    }
}
