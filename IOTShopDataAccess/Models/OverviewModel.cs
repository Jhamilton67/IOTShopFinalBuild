using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Models
{
    public class OverviewModel
    {
        public string ID { get; set; }
        public string FootFallCounter { get; set; }
        public DateTime Hourly { get; set; }
        public DateTimeOffset Day { get; set; }

        public int StockLevels { get; set; }
        public int ReplenCount { get; set; }
        public int StockTakeCount { get; set; }


        public static void FootFallCount()
        {
            List<FootFallModel> footFalls = new List<FootFallModel>();
        }

        public static void StockInfo()
        {
            List<StockLevelsModel> stockLevels = new List<StockLevelsModel>();
            List<StockTakeModel> stockTakes = new List<StockTakeModel>();
            List<ReplenModel> replens = new List<ReplenModel>();
        }
    }
}
