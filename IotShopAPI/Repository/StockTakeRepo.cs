using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI.Repository
{
    public class StockTakeRepo
    {
        public string ConnectionStringName; 


        public StockTakeRepo()
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

        public void AddData(StockTakeClass stock)
        {
            using(IDbConnection dbConnection = DbConnection)
            {
                string query = @"INSERT into dbo.StockTake (StockID, StockTakeCount, StockType, StockTypeSize,
	                            StockTypePrice, StockTypeQuantity) 
	                            values (@StockID, @StockTakeCount, @StockType, @StockTypeSize, @StockTypePrice, @StockTypeQuantity); ";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }

        }

        public IEnumerable<StockTakeClass> GetAll()
        {
            using(IDbConnection dbConnection = DbConnection)
            {
                string query = @"SELECT  * FROM dbo.StockTake";
                dbConnection.Open();
                return dbConnection.Query<StockTakeClass>(query); 
            }
        }

        public StockTakeClass GetAllByID(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"select Id, StockID, StockTakeCount,  StockType, StockTypeSize, StockTypePrice, StockTypeQuantity  
	                            from dbo.[StockTake];";
                dbConnection.Open();
                return dbConnection.Query<StockTakeClass>(query, new { StockID = id }).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"delete 
	                            from dbo.StockTake
	                            where Id = @Id;";
                dbConnection.Open();
                dbConnection.Execute(query, new { StockID = id });
            }
        }

        public void Update(StockTakeClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"update dbo.StockTake set 
	                            StockID = @StockID,
	                            StockTakeCount = StockTakeCount,
	                            StockType = StockType,
	                            StockTypeSize = @StockTypeSize,
	                            StockTypePrice = @StockTypePrice,
	                            StockTypeQuantity = @StockTypeQuantity
	                            where Id = @Id;";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }
        }



    }
}

