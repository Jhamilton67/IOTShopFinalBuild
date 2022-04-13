using Dapper;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI.Repository
{
    public class MainRepo
    {
        public string ConnectionStringName { get; set; } = "IotShopDataBase";


        public MainRepo()
        {
            ConnectionStringName = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IotTestData;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public IDbConnection dbConnection
        {
            get
            {
                return new SqlConnection(ConnectionStringName);
                
            }
        }
        #region AddingDataforControllers
        public void AddStockTakeData(StockTakeModel stock)
        {
            using (IDbConnection db = dbConnection)
            {
                string sql = @"INSERT INTO dbo.StockTake (StockTakeCount, StockID, StockType, StockTypeColour, StockTypeSize
                                StockTypePrice, StockTypeQuantity) VALUES (@StockTakeCount, @StockID, @StockType, @StockTypeColour, @StockTypeSize
                                @StockTypePrice, @StockTypeQuantity)";//Add in correct SQL 

                dbConnection.Open();
                dbConnection.Execute(sql, stock);
            }
            
        }

        public void AddStockLevelsData(StockLevelsModel stock)
        {
            using (IDbConnection db = dbConnection)
            {
                string sql = @"dbo.StockLevels_Insert.sql";//Add in correct SQL 

                dbConnection.Open();
                dbConnection.Execute(sql, stock);

            }

        }

        public void AddReplenData(ReplenModel stock)
        {
            using (IDbConnection db = dbConnection)
            {
                string sql = @"dbo.Replen_Insert.sql";//Add in correct SQL 

                dbConnection.Open();
                dbConnection.Execute(sql, stock);

            }

        }

        public void AddFootFallData(FootFallModel stock)
        {using (IDbConnection db = dbConnection)
            {
                string sql = @"dbo.FootFall_Insert.sql";
                dbConnection.Open();
                dbConnection.Execute(sql, stock);
            }
        }

        public void AddOverviewData(OverviewModel stock)
        {using (IDbConnection db = dbConnection)
            {
                string sql = @"INSERT into IOTShopDbFinal";
                dbConnection.Open();
                dbConnection.Execute(sql, stock);
            }
        }
        #endregion

        #region GETDataForControllers
        public IEnumerable<StockTakeModel> GetAllTakeModels()
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.StockTake_GetAll.sql";
                dbConnection.Open();
                return dbConnection.Query<StockTakeModel>(sql);
            }
        }

        public IEnumerable<StockLevelsModel> GetAllStockLevels()
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.StockLevels_GetAll.sql";
                dbConnection.Open();
                return dbConnection.Query<StockLevelsModel>(sql);
            }
        }

        public IEnumerable<FootFallModel> GetAllFootFallData()
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.FootFall_GetAll.sql";
                dbConnection.Open();
                return dbConnection.Query<FootFallModel>(sql);
            }
        }

        public IEnumerable<ReplenModel> GetAllReplenData()
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.Replen_GetAll.sql";
                dbConnection.Open();
                return dbConnection.Query<ReplenModel>(sql);
            }
        }

        public IEnumerable<OverviewModel> GetAllOverviewData()
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"SELECT * FROM IOTShopDbFinal";
                dbConnection.Open();
                return dbConnection.Query<OverviewModel>(sql);
            }
        }



        #endregion

        #region GETDataByID
        public StockTakeModel GETByID(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.StockTake_CountPercentage.sql";
                dbConnection.Open();
                return dbConnection.Query<StockTakeModel>(sql, new { StockID = id }).FirstOrDefault();
            }
        }

        public StockLevelsModel STLGETByID(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.StockLevels_CountPercentage";
                dbConnection.Open();
                return dbConnection.Query<StockLevelsModel>(sql, new { StockID = id }).FirstOrDefault();
            }
        }

        public ReplenModel RGETByID(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.Replen_CountPercentage";
                dbConnection.Open();
                return dbConnection.Query<ReplenModel>(sql, new { StockID = id }).FirstOrDefault();
            }
        }

        public FootFallModel FLGETByID(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.FootFall_CountPercentage";
                dbConnection.Open();
                return dbConnection.Query<FootFallModel>(sql, new { ID = id }).FirstOrDefault();
            }
        }

        public OverviewModel OGETByID(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"SELECT * FROM IOTShopDbFinal";
                dbConnection.Open();
                return dbConnection.Query<OverviewModel>(sql, new { ID = id }).FirstOrDefault();
            }
        }

        #endregion

        #region UpdateDataModel
        public void Update(StockTakeModel stock)
        {
            {
                using (IDbConnection db = dbConnection)
                {
                    string sql = @"dbo.StockTake_Update";
                    dbConnection.Open();
                    dbConnection.Execute(sql, stock);
                }
            }
        }

        public void UpdateSL(StockLevelsModel stock)
        {
            {
                using (IDbConnection db = dbConnection)
                {
                    string sql = @"dbo.StockLevels_Update";
                    dbConnection.Open();
                    dbConnection.Execute(sql, stock);
                }
            }
        }

        public void UpdateR(ReplenModel stock)
        {
            {
                using (IDbConnection db = dbConnection)
                {
                    string sql = @"dbo.Replen_Update";
                    dbConnection.Open();
                    dbConnection.Execute(sql, stock);
                }
            }
        }

        public void UpdateO(OverviewModel stock)
        {
           
            {using (IDbConnection db = dbConnection)
                {
                    string sql = @"SELECT * FROM IOTShopDbFinal";
                    dbConnection.Open();
                    dbConnection.Execute(sql, stock);
                }
            }
        }

        public void UpdateF(FootFallModel stock)
        {
            {
                using (IDbConnection db = dbConnection)
                {
                    string sql = @"dbo.FootFall_Update";
                    dbConnection.Open();
                    dbConnection.Execute(sql, stock);
                }
            }
        }

        #endregion

        #region DeleteData
        public void  Delete(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.StockTake_Delete";
                dbConnection.Open();
                dbConnection.Execute(sql, new { StockID = id }); 
            }
        }

        public void DeleteSL(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.StockLevels_Delete";
                dbConnection.Open();
                dbConnection.Execute(sql, new { StockID = id });
            }
        }

        public void DeleteR(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.Replen_Delete";
                dbConnection.Open();
                dbConnection.Execute(sql, new { StockID = id });
            }
        }

        public void DeleteF(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"dbo.FootFall_Delete";
                dbConnection.Open();
                dbConnection.Execute(sql, new { StockID = id });
            }
        }

        public void DeleteO(int id)
        {
            using (IDbConnection connection = dbConnection)
            {
                string sql = @"DELETE * FROM IOTShopDbFinal";
                dbConnection.Open();
                dbConnection.Execute(sql, new { StockID = id });
            }
        }

        #endregion
    }
}
