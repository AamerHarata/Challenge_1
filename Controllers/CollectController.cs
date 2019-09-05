using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using TestGoogle.Data;
using TestGoogle.Models;

namespace TestGoogle.Controllers
{
    public class CollectController : Controller
    {
        private readonly ApplicationDbContext _context;
        public static int Increment = 1;

        public CollectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/ReceiveData")]
        public IActionResult Index()
        {

            var collectedData = _context.MobileData.OrderByDescending(x => x.DateTime).ToList();

            
            return PartialView("Table", collectedData);
        }
        
        [Route("/ReceiveDefect")]
        public IActionResult Defect()
        {
            TestDefect();

            var collectedDefects = _context.Defects.OrderByDescending(x => x.Time).ToList();

            
            return PartialView("TableDefect", collectedDefects);
        }

        private void TestDefect()
        {
            var possibles = _context.Possibles.Where(x => !x.Tested).ToList();

            foreach (var pos in possibles)
            {
                pos.Tested = true;
                _context.Update(pos);
                _context.SaveChanges();
                
                var prev = _context.MobileData.Where(x => x.DateTime < pos.Time && (x.DateTime > pos.Time.Subtract(new TimeSpan(0, 0, 1)))).ToList();

//                var prev = _context.MobileData.Where(x => x.DateTime > pos.Time.Subtract(new TimeSpan(0, 0, 10)));
//                Console.Write(prev);
                foreach (var pr in prev)
                {
                    if (double.Parse(pr.zAco) > 12 || double.Parse(pr.zAco) < 4)
                    {
                        continue;
                    }
                    
                    var defect = new Defect()
                    {
                        xAco = pos.xAco, yAco = pos.yAco, zAco = pos.zAco, Time = pos.Time, TestNumber = pos.TestNumber
                    };

                    _context.Add(defect);
                    _context.SaveChanges();
                }

            }
            
            
        }




    }
}