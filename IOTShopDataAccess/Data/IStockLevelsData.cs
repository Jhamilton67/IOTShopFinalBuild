using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public interface IStockLevelsData
    {
        Task<List<StockLevelsModel>> GetStockLevels();
        Task InsertStockLevels(StockLevelsModel stock);
    }
}