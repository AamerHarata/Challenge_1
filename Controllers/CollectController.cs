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

            var collectedData = _context.MobileDataBike.OrderByDescending(x => x.DateTime).ToList();

            
            return PartialView("Table", collectedData);
        }

        [Route("/ReceiveInfo/{testNumber?}")]
        public IActionResult Info(int testNumber)
        {
            if(testNumber == 0)
                return Ok();

            ViewBag.testNumber = testNumber;
            return PartialView("Info");
        }
        
        [Route("/ReceiveDefect")]
        public IActionResult Defect()
        {
            TestDefect();

            var collectedDefects = _context.Defects.OrderByDescending(x => x.Time).ToList();

            
            return PartialView("TableDefect", collectedDefects);
        }

        [Route("/TestDefect")]
        public void TestDefect()
        {
            var possibles = _context.Possibles.Where(x => !x.Tested).ToList();
            var allData = _context.MobileDataBike.OrderBy(x=>x.DateTime).ToList();
            
            foreach (var pos in possibles)
            {
                pos.Tested = true;
                _context.Update(pos);
                _context.SaveChanges();

                for (var i = 12; i < allData.Count; i++)
                {
                    var added = true;
                    
                    if (allData[i].Id != pos.Id) continue;
                    
                    var tempList = new List<MobileData>();
                    
                    for(var j = i-1; j != i-10 ; j--)
                        tempList.Add(allData[j]);


                    if (tempList.Any(x=>double.Parse(x.zAco) > 20) || tempList.Any(x=>double.Parse(x.zAco) < 2) || !tempList.Any())
                    {
                        
                    }
                    else
                    {
                        var defect = new Defect()
                        {
                            Id = allData[i].Id, xAco = allData[i].xAco, yAco = allData[i].yAco, zAco = allData[i].zAco, Time = allData[i].DateTime, TestNumber = allData[i].TestNumber,
                            xGeo = allData[i].xGeo, yGeo = allData[i].yGeo, DefType = pos.Type
                        };

                        try
                        {
                            _context.Add(defect);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        _context.SaveChanges();
                    }
                    
                    
                   

                    
                }
                

            }
            
            
        }




    }
}