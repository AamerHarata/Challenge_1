using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestGoogle.Data;
using TestGoogle.Models;
using TestGoogle.Services;

namespace TestGoogle.API
{
    [ApiController]
    public class GetMobileData : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GetMobileData(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/api/GetData")]
        public async Task<IActionResult> LiveData(string xAco, string yAco, string zAco, string xGeo, string yGeo, int testNumber)
        {
            var result = new MobileData()
            {
                xAco = xAco, yAco = yAco, zAco = zAco, xGeo = xGeo, yGeo = yGeo, TestNumber = testNumber
            };

            if (double.Parse(zAco) > 12)
            {
                var posible = new Possible()
                {
                    xAco = xAco, yAco = yAco,zAco = zAco,xGeo = xGeo, yGeo = yGeo, TestNumber = testNumber, Type = DefType.Hole
                };

                await _context.AddAsync(posible);
                await _context.SaveChangesAsync();
            }else if (double.Parse(zAco) < 4)
            {
                var posible = new Possible()
                {
                    xAco = xAco, yAco = yAco,zAco = zAco,xGeo = xGeo, yGeo = yGeo, TestNumber = testNumber, Type = DefType.Bump
                };

                await _context.AddAsync(posible);
                await _context.SaveChangesAsync();
            }

            await _context.AddAsync(result);
            await _context.SaveChangesAsync();

            return Ok(new {xAco, yAco, zAco});
        }


//        [Route("/api/ReceiveData")]
//        public async Task<IActionResult> GetAllData()
//        {
//            
//            return Ok(await _context.MobileData.ToListAsync());
//        }
        
    }
}