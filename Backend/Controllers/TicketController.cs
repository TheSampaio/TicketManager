using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]s"), ApiController]
    public class TicketController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAllTickets()
        {
            var tickets = await _context.Tickets.ToListAsync();
            return Ok(tickets);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTicketById(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket is null)
                return NotFound("Ticket not found.");

            return Ok(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(TicketRequest ticketRequest)
        {
            // Validade request body
            if (ticketRequest is null)
                return BadRequest("Request body is required.");

            var ticketModel = new TicketModel
            {
                Title = ticketRequest.Title,
                Description = ticketRequest.Description,
                RequesterId = ticketRequest.RequesterId,
                CreatedAt = DateTime.UtcNow
            };

            // Update the database using the ticketModel
            await _context.Tickets.AddAsync(ticketModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetTicketById),          // The action name
                new { id = ticketModel.Id },    // Route values
                ticketModel                     // Response body
            );
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateTicket(int id, TicketRequest ticketRequest)
        {
            // Validade request body
            if (ticketRequest is null)
                return BadRequest("Request body is required.");

            // TODO: PUT method logic...
           
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteTicketById(int id)
        {
            // TODO: DELETE method logic...
            return NoContent();
        }
    }
}
