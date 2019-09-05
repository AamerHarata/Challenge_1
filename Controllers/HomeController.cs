using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestGoogle.Data;
using TestGoogle.Models;
using System.Web;


namespace TestGoogle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult DeleteAll()
        {
            var allData = _context.MobileData.ToList();
            _context.RemoveRange(allData);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Route("/SaveData/{testNumber?}")]
        public IActionResult SaveData(string testNumber)
        {
            var result = new List<MobileData>();
            if (string.IsNullOrEmpty(testNumber))
                result = _context.MobileData.OrderBy(x=>x.DateTime).ToList();
            
            else
            {
                result = _context.MobileData.Where(x => x.TestNumber.ToString() == testNumber).OrderBy(x=>x.DateTime).ToList();
            }
            
            
            
            string csv = ListToCSV(result);
            
            
            
            
            
            
            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "something.csv" );
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
        
        
        
        
        private string ListToCSV<T>(IEnumerable<T> list)
        {
            StringBuilder sList = new StringBuilder();

            Type type = typeof(T);
            var props = type.GetProperties();
            sList.Append(string.Join(",", props.Select(p => p.Name)));
            sList.Append(Environment.NewLine);

            foreach (var element in list)
            {
                sList.Append(string.Join(",", props.Select(p => p.GetValue(element, null))));
                sList.Append(Environment.NewLine);
            }

            return sList.ToString();
        }
    }
}
