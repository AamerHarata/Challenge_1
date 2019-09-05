using System;
using System.Collections.Generic;
using System.Linq;
using TestGoogle.Data;
using TestGoogle.Models;

namespace TestGoogle.Services
{
    public class TestService : ITestService
    {
        private readonly ApplicationDbContext _context;

        public TestService(ApplicationDbContext context)
        {
            _context = context;
            
        }
        
        public List<TimeSpan> GetStartEndTime(int testNumber)
        {
            var test = _context.MobileData.Where(x => x.TestNumber == testNumber).ToList();

            var min = test.Min(x => x.DateTime);
            var max = test.Max(x => x.DateTime);
            
            return new List<TimeSpan>(){min.TimeOfDay, max.TimeOfDay};
        }

        public List<MobileData> GetAllTestData(int testNumber)
        {
            return _context.MobileData.Where(x => x.TestNumber == testNumber).ToList();
        }
    }
}