using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.Models
{
    public class DisplayReplenModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Data is too long")]
        public string ReplenCounter { get; set; }
        [StringLength(50, ErrorMessage = "Data is too long")]
        public string StockID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Data is too long")]
        public string StockType { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Data is too long")]
        public string StockTypeSize { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Data is too long")]
        public string StockTypeQuantityNeeded { get; set; }
    }
}
