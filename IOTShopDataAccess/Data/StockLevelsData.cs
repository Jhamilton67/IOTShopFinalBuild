using IOTShopDataAccess.Data_Access;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public class StockLevelsData : IStockLevelsData
    {
        private readonly ISQLDataAccess _db;

        public StockLevelsData(ISQLDataAccess db)
        {
            _db = db;
        }


        public Task<List<StockLevelsModel>> GetStockLevels()
        {
            string sql = "select  * from dbo.StockLevels"; //TODO Add in name of Database 

            return _db.LoadData<StockLevelsModel, dynamic>(sql, new { });
        }

        public Task InsertStockLevels(StockLevelsModel stock)
        {
            string sql = @"insert into dbo.StockLevels";//Need tp add in Database then
                                                              //Then finish code for the query
            return _db.SaveData(sql, stock);
        }
    }
}
