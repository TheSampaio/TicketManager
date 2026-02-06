using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    public class KnowledgeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
