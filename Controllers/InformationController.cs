using Microsoft.AspNetCore.Mvc;

namespace RoyalJelly.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Databases()
        {
            return View();
        }

        public IActionResult Culture()
        {
            return View();
        }
    }
}