using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestGoogle.Data;

namespace TestGoogle.Controllers
{
    public class Challenge_2Controller : Controller
    {
        private readonly ApplicationDbContext _context;
        public Challenge_2Controller(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var results = _context.BluetoothLeDevices.ToList();
            
            return View(results);
        }
        
    }
}