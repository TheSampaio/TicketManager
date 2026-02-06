using Microsoft.AspNetCore.Mvc;
using TicketSystem.Utilities;

namespace TicketSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(
                nameof(DashboardController.Index),
                ControllerRoute.GetName<DashboardController>()
            );
        }
    }
}
