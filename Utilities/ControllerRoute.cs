using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Utilities
{
    public static class ControllerRoute
    {
        private const string Suffix = "Controller";

        public static string GetName<T>() where T : Controller
        {
            return typeof(T).Name.Replace(Suffix, string.Empty);
        }
    }
}
