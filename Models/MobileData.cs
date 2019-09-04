using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestGoogle.Models
{
    public class MobileData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string xAco { get; set; }
        public string yAco { get; set; }
        public string zAco { get; set; }
        public string xGeo { get; set; }
        public string yGeo { get; set; }
    }
}