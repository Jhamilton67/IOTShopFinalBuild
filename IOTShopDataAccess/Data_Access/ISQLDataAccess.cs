using IOTShopDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data_Access
{
    public interface ISQLDataAccess
    {
        string ConnectionStringName { get; set; }
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
        
    }
}