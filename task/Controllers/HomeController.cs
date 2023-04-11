using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task.Data;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}