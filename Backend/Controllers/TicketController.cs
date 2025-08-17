using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]s"), ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            // TODO: GET method logic...
            return Ok();
        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetById(Guid id)
        {
            // TODO: GET method logic...
            return Ok();
        }

        [HttpPost]
        public IActionResult PostContent()
        {
            // TODO: POST method logic...
            return Created();
        }

        [HttpPut("{id:Guid}")]
        public IActionResult PutById(Guid id)
        {
            // TODO: PUT method logic...
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult DeleteById(Guid id)
        {
            // TODO: DELETE method logic...
            return NoContent();
        }
    }
}
