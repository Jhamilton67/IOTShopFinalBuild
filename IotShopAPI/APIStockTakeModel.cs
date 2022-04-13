using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI
{
    public class APIStockTakeModel
    {
        public int StockID { get; set; }
        public int StockTakeCount { get; set; }
        public string StockType { get; set; }
        public string StockTypeSize { get; set; }
        public decimal StockTypePrice { get; set; }
        public string StockTypeColour { get; set; }
        public string StockTypeQuantity { get; set; }
    }
}
