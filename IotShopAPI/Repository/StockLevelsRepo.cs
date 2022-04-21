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
    public class StockLevelsRepo
    {
        public string ConnectionStringName;


        public StockLevelsRepo()
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

        public void AddData(StockLevelsClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"insert into dbo.[StockLevels] (StockID, StockLevels, StockType, Quantity)
                                values (@StockID, @StockLevels, @StockType, @Quantity) ";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }

        }

        public IEnumerable<StockLevelsClass> GetAll()
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"SELECT  * FROM dbo.StockLevels";
                dbConnection.Open();
                return dbConnection.Query<StockLevelsClass>(query);
            }
        }

        public StockLevelsClass GetAllByID(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"select Id, [StockLevels], StockID, StockLevels, StockImage, Quantity 
	                            from dbo.[StockLevels];";
                dbConnection.Open();
                return dbConnection.Query<StockLevelsClass>(query, new { StockID = id }).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"delete 
	                            from dbo.[StockLevels]
	                            where Id = @Id;";
                dbConnection.Open();
                dbConnection.Execute(query, new { StockID = id });
            }
        }

        public void Update(StockLevelsClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @" update dbo.[StockLevels] set 
                                    StockID = @StockID,
                                    StockLevels = @StockLevels, 
                                    StockType = @StockType,
                                    Quantity = @Quantity,
                                    StockImage = @StockImage
                                    where Id = @ID";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }
        }
    }
}
