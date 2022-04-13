using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public interface IStockTakeData
    {
        Task<List<StockTakeModel>> GetStockTakes();
        Task InsertStock(StockTakeModel stock);
        //Need to Test 
        Task DeleteStockTake(int id);
        Task<List<StockTakeModel>> GetStockTakesData();
        Task<StockTakeModel> StockTakeModelID(int id);
        Task UpdateStockTake(StockTakeModel stock);
    }
}