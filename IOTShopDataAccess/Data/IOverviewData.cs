using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public interface IOverviewData
    {
        Task<List<OverviewModel>> GetInfo();
        Task InsertInfo(StockTakeModel stock);
    }
}