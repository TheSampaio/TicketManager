using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
