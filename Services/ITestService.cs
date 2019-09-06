using System;
using System.Collections.Generic;
using TestGoogle.Models;

namespace TestGoogle.Services
{
    public interface ITestService
    {
        List<TimeSpan> GetStartEndTime(int testNumber);
        List<MobileData> GetAllTestData(int testNumber);
        int CountHoles(int testNumber);
        int CountBumps(int testNumber);
        List<double> GetAco(int testNumber);
        List<double> GetGeo(int testNumber);
    }
}