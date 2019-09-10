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
            var results = _context.BluetoothLeDevices.OrderBy(x=>x.TestNr).ToList();
            
            return View(results);
        }


        [Route("/Challenge_2/Delete/{testNr?}")]
        public IActionResult Delete(int testNr)
        {
            _context.RemoveRange(_context.BluetoothLeDevices.ToList());
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        
    }
}