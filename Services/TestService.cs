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
            
            return new List<TimeSpan>(){min.TimeOfDay.Add(new TimeSpan(2,0,0)), max.TimeOfDay.Add(new TimeSpan(2,0,0))};
        }

        public List<MobileData> GetAllTestData(int testNumber)
        {
            return _context.MobileData.Where(x => x.TestNumber == testNumber).ToList();
        }

        public int CountHoles(int testNumber)
        {
            return _context.Defects.Where(x => x.TestNumber == testNumber).Count(x => x.DefType == DefType.Hole);
        }
        
        public int CountBumps(int testNumber)
        {
            return _context.Defects.Where(x => x.TestNumber == testNumber).Count(x => x.DefType == DefType.Bump);
        }

        public List<double> GetAco(int testNumber)
        {
            var result = _context.MobileData.Where(x => x.TestNumber == testNumber).OrderByDescending(x=>x.DateTime).Take(1).First();
            
            return new List<double>(){Math.Round(double.Parse(result.xAco), 3), Math.Round(double.Parse(result.yAco), 3), Math.Round(double.Parse(result.zAco),3)};
        }
        
        public List<double> GetGeo(int testNumber)
        {
            var result = _context.MobileData.Where(x => x.TestNumber == testNumber).OrderByDescending(x=>x.DateTime).Take(1).First();
            
            return new List<double>(){double.Parse(result.xGeo), double.Parse(result.yGeo)};
        }
    }
}