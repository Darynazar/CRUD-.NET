using Microsoft.AspNetCore.Mvc;

namespace Hospital_Web.Controllers
{
    public class Menu : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
