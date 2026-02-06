using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    public class ActivesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
