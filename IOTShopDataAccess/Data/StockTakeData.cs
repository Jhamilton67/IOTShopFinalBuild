using IOTShopDataAccess.Data_Access;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public class StockTakeData : IStockTakeData
    {

        private readonly ISQLDataAccess _db;

        public StockTakeData(ISQLDataAccess db)
        {
            _db = db;
        }
        public Task<List<StockTakeModel>> GetStockTakes()
        {
            string sql = "select  * from dbo.IOTShopDbFinal"; //TODO Update The connection string in StockTakeData 

            return _db.LoadData<StockTakeModel, dynamic>(sql, new { });
        }

        public Task InsertStock(StockTakeModel stock)
        {
            string sql = @"insert into dbo.IOTShopDbFinal";

            return _db.SaveData(sql, stock);
        }

    }
}

