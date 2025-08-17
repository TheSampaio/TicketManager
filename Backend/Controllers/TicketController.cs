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

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var ticket = _context.Tickets.Find(id);

            if (ticket is null)
                return NotFound("Ticket not found.");

            return Ok(ticket);
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
