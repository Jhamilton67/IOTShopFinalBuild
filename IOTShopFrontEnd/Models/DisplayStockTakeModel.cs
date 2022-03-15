using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.Models
{
    public class DisplayStockTakeModel
    {
        [Required]
        public int StockTakeCount { get; set; }
        [Required]
        public int StockID { get; set; }
        [Required]
        public string StockType { get; set; }
        [Required]
        public string StockTypeSize { get; set; }
        [Required]
        public decimal StockTypePrice { get; set; }
        [Required]
        public string StockTypeColour { get; set; }
        [Required]
        public string StockTypeQuantity { get; set; }
    }
}
