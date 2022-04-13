using System;
using System.Collections.Generic;

namespace IOTShopDataAccess.Models
{
    public class FootFallModel
    {
        public int ID { get; set; }
        public string FootFallCounter { get; set; }
        public DateTime Hourly { get; set; }
        public DateTimeOffset Day { get; set; }

        public static void FootFallCount()
        {
            List<FootFallModel> footFalls = new List<FootFallModel>();
        }

    }
}