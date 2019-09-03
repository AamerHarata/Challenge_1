using System;

namespace TestGoogle.Models
{
    public class MobileData
    {
        public int Id { get; set; } = new Random().Next(0000000, 9999999); 
        public string xAco { get; set; }
        public string yAco { get; set; }
        public string zAco { get; set; }
    }
}