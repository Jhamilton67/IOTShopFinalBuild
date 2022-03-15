using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Models
{
    public class StockTakeModel
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
