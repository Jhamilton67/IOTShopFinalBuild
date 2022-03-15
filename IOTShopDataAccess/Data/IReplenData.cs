using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public interface IReplenData
    {
        Task<List<ReplenModel>> GetReplens();
        Task InsertReplen(ReplenModel stock);
    }
}