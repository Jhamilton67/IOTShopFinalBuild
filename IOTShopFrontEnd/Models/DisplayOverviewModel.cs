using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.Models
{
    public class DisplayOverviewModel
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string FootFallCounter { get; set; }
        [Required]
        public DateTime Hourly { get; set; }
        [Required]
        public DateTimeOffset Day { get; set; }
        [Required]
        public int StockLevels { get; set; }
        [Required]
        public int ReplenCount { get; set; }
        [Required]
        public int StockTakeCount { get; set; }
    }
}
