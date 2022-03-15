using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Models
{
    public class ReplenModel
    {
        public string StockID { get; set; }
        public int ReplenCount { get; set; }
        public string StockType { get; set; }
        public string StockTypeSize { get; set; }
        public string StockTypeQuantityNeeded { get; set; }
    }
}
