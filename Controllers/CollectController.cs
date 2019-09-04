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

        public CollectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/ReceiveData")]
        public IActionResult Index()
        {

            return PartialView("Table", _context.MobileData.OrderBy(x => x.DateTime).ToList());
        }




    }
}