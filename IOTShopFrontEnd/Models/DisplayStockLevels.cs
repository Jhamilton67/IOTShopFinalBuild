using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.Models
{
    public class DisplayStockLevels
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string StockLevels { get; set; }
        [Required]
        public string StockID { get; set; }
        [Required]
        public string StockType { get; set; }
        [Required]
        public string Quantity { get; set; }
        [Required]
        public string ProductImage { get; set; }
    }
}
