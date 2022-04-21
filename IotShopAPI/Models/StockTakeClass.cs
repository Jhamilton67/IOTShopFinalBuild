using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI
{
    public class StockTakeClass
    {
        [Key]
        public int ID { get; set; }

        public int StockID { get; set; }
        
        public string StockType { get; set; }
      
        public string StockTypeSize { get; set; }
      
        public decimal StockTypePrice { get; set; }
     
        public string StockTypeColour { get; set; }
      
        public string StockTypeQuantity { get; set; }

        public int StockTakeCount { get; set; }

    }
}
