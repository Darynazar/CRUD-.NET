using Microsoft.AspNetCore.Mvc;
using Hospital_Web.Data;
using Hospital_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Web.Controllers
{
    public class Menu : Controller
    {
        private readonly MenuContext _context;
        public Menu(MenuContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _context.Dishes.ToListAsync());
        }
    }
}
