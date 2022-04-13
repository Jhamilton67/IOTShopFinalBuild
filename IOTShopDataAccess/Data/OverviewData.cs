using IOTShopDataAccess.Data_Access;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public class OverviewData : IOverviewData
    {
        private readonly ISQLDataAccess _db;

        public OverviewData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<OverviewModel>> GetInfo()
        {
            string sql = "select  * from dbo.Overview"; //TODO Add in name of Database 

            return _db.LoadData<OverviewModel, dynamic>(sql, new { });
        }

        public Task InsertInfo(StockTakeModel stock)
        {
            string sql = @"insert into dbo.Overview";//Need tp add in Database then
                                                              //Then finish code for the query

            return _db.SaveData(sql, stock);
        }
    }
}
