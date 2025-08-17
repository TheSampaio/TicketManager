using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]s"), ApiController]
    public class TicketController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public IActionResult GetAll()
        {
            var tickets = _context.Tickets.ToList();
            return Ok(tickets);
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
