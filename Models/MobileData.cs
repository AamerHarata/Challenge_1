using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestGoogle.Models
{
    public class MobileData
    {
        public string Id { get; set; }
        public string xAco { get; set; }
        public string yAco { get; set; }
        public string zAco { get; set; }
        public string xGeo { get; set; }
        public string yGeo { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool Collected { get; set; }
        public int Increment { get; set; }
        public int TestNumber { get; set; }
    }
}