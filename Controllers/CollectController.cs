using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            //ToDo:: Get All data from database
            //ToDo:: Check where do we have bump or hole algorithm
            //ToDo:: Order them by time stamp
            //ToDo:: Show them in the list
            
            
            
            
            
            
            var collectedData = _context.MobileData.OrderByDescending(x => x.DateTime).ToList();

//            foreach (var result in collectedData)
//            {
//                result.Increment = Increment;
//                result.Collected = true;
//                _context.Update(result);
//                _context.SaveChanges();
//                Increment++;
//
//            }

            return PartialView("Table", collectedData);
        }




    }
}