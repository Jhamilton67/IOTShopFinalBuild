using IOTShopDataAccess.Data_Access;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTShopDataAccess.Data
{
    public class FootFallData : IFootFallData
    {
        private readonly ISQLDataAccess _db;
        public FootFallData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<FootFallModel>> GetFootFall()
        {
            string sql = "select  * from dbo.IOTShopDbFinal"; //Add in name of Database 

            return _db.LoadData<FootFallModel, dynamic>(sql, new { });
        }

        public Task InsertFootFall(FootFallModel stock)
        {
            string sql = @"insert into dbo.IOTShopDbFinal";// TODO Need tp add in Database then
                                                              //Then finish code for the query

            return _db.SaveData(sql, stock);
        }

    }
}
