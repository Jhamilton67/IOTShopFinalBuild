using Dapper;
using IOTShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI.Repository
{
    public class ReplenRepo
    {

        public string ConnectionStringName;


        public ReplenRepo()
        {
            ConnectionStringName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IotTestData;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }


        public IDbConnection DbConnection
        {
            get
            {
                return new SqlConnection(ConnectionStringName);

            }
        }

        public void AddData(ReplenClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @" INSERT into dbo.Replen (StockID, ReplenCount, StockType, StockTypeSize, StockTypeQuantityNeeded)
                                  values (@StockID, @ReplenCount, @stockType, @stockTypeSize, @stockTypeQuantityNeeded); ";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }

        }

        public IEnumerable<ReplenClass> GetAll()
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"SELECT  * FROM dbo.Replen";
                dbConnection.Open();
                return dbConnection.Query<ReplenClass>(query);
            }
        }

        public ReplenClass GetAllByID(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"select Id, ReplenCount, StockID   StockType, StockTypeSize, StockTypeQuantityNeeded
	                            from dbo.Replen;";
                dbConnection.Open();
                return dbConnection.Query<ReplenClass>(query, new { StockID = id }).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"delete 
	                            from dbo.Replen
	                            where Id = @Id";
                dbConnection.Open();
                dbConnection.Execute(query, new { StockID = id });
            }
        }

        public void Update(ReplenClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @" update dbo.Replen set 
                                    StockID = @StockID,
                                    ReplenCount = @Replen_Count,
                                    StockType = @StockType,
                                    StockTypeSize = @StockTypeSize,
                                    StockTypeQuantityNeeded = @StockTypeQunatityNeeded
                                    where Id = @ID";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }
        }


    }
}
