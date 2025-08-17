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
            // Returns all tickets from the database
            var tickets = await _context.Tickets.ToListAsync();
            return Ok(tickets);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTicketById(int id)
        {
            // Returns a ticket by its Id, or 404 if not found
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket is null)
                return NotFound("Ticket not found.");

            return Ok(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(TicketPostRequest ticketRequest)
        {
            var ticketModel = new TicketModel
            {
                Title = ticketRequest.Title,
                Description = ticketRequest.Description,
                RequesterId = ticketRequest.RequesterId,
                CreatedAt = DateTime.UtcNow
            };

            // Adds a new ticket to the database
            await _context.Tickets.AddAsync(ticketModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetTicketById),          // Action name for location header
                new { id = ticketModel.Id },    // Route values
                
                // Response body
                new TicketPostResponse
                {
                    Id = ticketModel.Id,
                    Title = ticketModel.Title,
                    Description = ticketModel.Description,
                    RequesterId = ticketModel.RequesterId,
                    CreatedAt = ticketModel.CreatedAt,
                }
            );
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateTicket(int id, TicketPutRequest ticketRequest)
        {
            // Finds the ticket by Id, or returns 404 if not found
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket is null)
                return NotFound("Ticket not found.");

            // Updates the ticket's properties
            ticket.Title = ticketRequest.Title;
            ticket.Description = ticketRequest.Description;
            ticket.RequesterId = ticketRequest.RequesterId;
            ticket.TechnicianId = ticketRequest.TechnicianId;
            ticket.CompletedAt = ticketRequest.CompletedAt;

            await _context.SaveChangesAsync();
           
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteTicketById(int id)
        {
            // Finds the ticket by Id, or returns 404 if not found
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket is null)
                return NotFound("Ticket not found.");

            // Deletes the ticket from the database
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
