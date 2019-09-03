using Microsoft.AspNetCore.Mvc;
using TestGoogle.Data;
using TestGoogle.Models;

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
        public IActionResult LiveDate(string xAco, string yAco, string zAco)
        {
            var result = new MobileData()
            {
                xAco = xAco, yAco = yAco, zAco = zAco
            };

            _context.Add(result);
            _context.SaveChanges();
            


            return Ok(new {xAco, yAco, zAco});
        }
        
    }
}