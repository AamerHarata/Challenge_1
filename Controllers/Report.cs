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
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITestService _testService;

        public ReportController(ApplicationDbContext context, ITestService testService)
        {
            _context = context;
            _testService = testService;
        }
        public IActionResult StaticData(int testNumber)
        {
            ViewBag.testNumber = testNumber;
            return View(_context.MobileDataBike.Where(x=>x.TestNumber == testNumber).OrderBy(x=>x.DateTime).ToList());
        }

        public IActionResult StaticMap(int testNumber)
        {
            ViewBag.testNumber = testNumber;
            return View(_context.Defects.Where(x => x.TestNumber == testNumber).OrderBy(x => x.Time).ToList());
        }


        
    }
}
