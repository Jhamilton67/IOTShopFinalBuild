using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public interface IStockTakeData
    {
        Task<List<StockTakeModel>> GetStockTakes();
        Task InsertStock(StockTakeModel stock);
    }
}