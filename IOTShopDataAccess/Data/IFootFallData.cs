using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public interface IFootFallData
    {
        Task<List<FootFallModel>> GetFootFall();
        Task InsertFootFall(FootFallModel stock);
    }
}