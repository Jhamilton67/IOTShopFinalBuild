using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.Models
{
    public class DisplayFootFall
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string FootFallCounter { get; set; }
        [Required]
        public DateTime Hourly { get; set; }
        [Required]
        public DateTimeOffset Day { get; set; }
    }
}
