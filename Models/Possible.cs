using System;
using TestGoogle.Services;

namespace TestGoogle.Models
{
    public class Possible
    {
        public string Id { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public int TestNumber { get; set; }
        public string xAco { get; set; }
        public string yAco { get; set; }
        public string zAco { get; set; }
        public string xGeo { get; set; }
        public string yGeo { get; set; }
        public DefType Type { get; set; }
        public bool Tested { get; set; }
    }
}