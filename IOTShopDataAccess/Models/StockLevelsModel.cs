using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Models
{
    public class StockLevelsModel
    {
        public int ID { get; set; }
        public string StockLevels { get; set; }
        public int StockID { get; set; }
        public string StockType { get; set; }
        public string Quantity { get; set; }
        public string ProductImage { get; set; }
    }
}
