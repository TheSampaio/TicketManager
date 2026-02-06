using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
