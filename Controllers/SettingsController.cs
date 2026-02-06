using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}