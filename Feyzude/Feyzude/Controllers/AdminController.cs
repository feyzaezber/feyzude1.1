using Microsoft.AspNetCore.Mvc;

namespace Feyzude.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
