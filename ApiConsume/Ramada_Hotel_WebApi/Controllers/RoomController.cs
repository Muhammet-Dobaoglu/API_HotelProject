using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ramada_Hotel_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok();
        }

    }
}
