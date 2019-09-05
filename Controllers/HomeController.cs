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
using TestGoogle.Services;


namespace TestGoogle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITestService _testService;

        public HomeController(ApplicationDbContext context, ITestService testService)
        {
            _context = context;
            _testService = testService;
        }
        public IActionResult Index()
        {
            
            return View();
        }


        public IActionResult AllData()
        {
            return View();
        }

        [Route("/DeleteData/{testNumber?}")]
        public IActionResult DeleteAll(string testNumber)
        {
            var allData = new List<MobileData>();

            allData = string.IsNullOrEmpty(testNumber) ? _context.MobileData.ToList() : _context.MobileData.Where(x=>x.TestNumber.ToString() == testNumber).ToList();
            
            _context.RemoveRange(allData);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Route("/SaveData/{testNumber?}")]
        public IActionResult SaveData(string testNumber)
        {
            var result = new List<MobileData>();
            var fileName = "";
            
            if (string.IsNullOrEmpty(testNumber)){
                result = _context.MobileData.OrderBy(x=>x.DateTime).ToList();
                fileName = "AllData.csv";
            }
            
            
            else
            {
                result = _context.MobileData.Where(x => x.TestNumber.ToString() == testNumber).OrderBy(x=>x.DateTime).ToList();
                fileName = "DataForTestNr-" + testNumber + ".csv";
            }
            
            
            
            string csv = ListToCSV(result);
            
            
            
            
            
            
            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", fileName );
        }


        public IActionResult Summery()
        {
            var tests = new List<int>();
            tests.AddRange(from b in _context.MobileData
                group b by b.TestNumber
                into g
                select g.First().TestNumber);
            
            var vm = new List<SummeryViewModel>();

            foreach (var test in tests)
            {
                var timing = _testService.GetStartEndTime(test);
                
                vm.Add(new SummeryViewModel(){TestNumber = test, StartTime = timing[0], EndTime = timing[1]});
            }


            

            
            
            return View(vm);
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
        
        
        
        
        
        
        private string ListToCSV(IEnumerable<MobileData> list)
        {
            StringBuilder sList = new StringBuilder();

//            Type type = typeof(T);
//            var props = type.GetProperties();

            sList.AppendFormat("{0},{1},{2},{3},{4}, {5},{6},{7}", "#","Time", "xAco", "yAco", "zAco", "xGeo", "yGeo",
                "Test Nr.");
            
//            sList.Append(string.Join(",", props.Select(p => p.Name)));
            sList.Append(Environment.NewLine);

            var i = 1;
            foreach (var element in list)
            {
//                sList.Append(string.Join(",", props.Select(p => p.GetValue(element, null))));
                sList.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}", i, element.DateTime.ToString((@"hh\:mm:ss")), element.xAco, element.yAco, element.zAco,
                    element.xGeo, element.yGeo, element.TestNumber);
                sList.Append(Environment.NewLine);
                i++;
            }

            return sList.ToString();
        }
    }
}
