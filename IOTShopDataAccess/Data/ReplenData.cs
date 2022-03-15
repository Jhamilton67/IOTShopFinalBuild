using IOTShopDataAccess.Data_Access;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public class ReplenData : IReplenData
    {
        private readonly ISQLDataAccess _db;

        public ReplenData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<ReplenModel>> GetReplens()
        {
            string sql = "select  * from dbo.IOTShopDbFinal";

            return _db.LoadData<ReplenModel, dynamic>(sql, new { });
        }

        public Task InsertReplen(ReplenModel stock)
        {
            string sql = @"insert into dbo.IOTShopDbFinal";//TODO Need tp add in Database then
                                                              //Then finish code for the query
            return _db.SaveData(sql, stock);
        }
    }
}
