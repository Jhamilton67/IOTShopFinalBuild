using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI.Models
{
    public class ReplenClass
    {
        public string ReplenCounter { get; set; }
        public int StockID { get; set; }
       
        public string StockType { get; set; }
       
        public string StockTypeSize { get; set; }
        
        public string StockTypeQuantityNeeded { get; set; }
    }
}

