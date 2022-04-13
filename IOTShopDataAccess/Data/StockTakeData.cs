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
            string sql = "SELECT  * from dbo.StockTake"; //TODO Update The connection string in StockTakeData 

            return _db.LoadData<StockTakeModel, dynamic>(sql, new { });
        }

        public Task InsertStock(StockTakeModel stock)
        {
            string sql = @"INSERT into dbo.StockTake";

            return _db.SaveData(sql, stock);
        }

        public Task<List<StockTakeModel>> GetStockTakesData()
        {
            string sql = "dbo.StockTake";//Insert Stored Procedure 

            return _db.LoadData<StockTakeModel, dynamic>(sql, new { }); 

        }

        public async Task<StockTakeModel> StockTakeModelID(int id)
        {
            string sql = "dbo.spStockTake_GetID";

            var results = await _db.LoadData<StockTakeModel, dynamic>(sql, new { StockID = id});
            return results.FirstOrDefault(); 
        }

        public Task UpdateStockTake(StockTakeModel stock)
        {
            string sql = "dbo.spStockTake_Update";

            return _db.SaveData(sql, stock);
        }

        public Task DeleteStockTake(int id)
        {
            string sql = "dbo.spStockTake_Delete";

            return _db.SaveData(sql, new { StockID = id }); 
        }
    }
}

