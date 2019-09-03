using System.Threading.Tasks;
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
        public async Task<IActionResult> LiveDate(string xAco, string yAco, string zAco)
        {
            var result = new MobileData()
            {
                xAco = xAco, yAco = yAco, zAco = zAco
            };

            await _context.AddAsync(result);
            await _context.SaveChangesAsync();
            


            return Ok(new {xAco, yAco, zAco});
        }
        
    }
}