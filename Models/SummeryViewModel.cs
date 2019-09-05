using System;
using System.ComponentModel.DataAnnotations;

namespace TestGoogle.Models
{
    public class SummeryViewModel
    {
        public int TestNumber { get; set; }
        
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{HH:mm}")]
        public TimeSpan StartTime { get; set; }
        
        
        [DisplayFormat(DataFormatString = "{HH:mm}")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }
        public double Period { get; set; }
    }
}