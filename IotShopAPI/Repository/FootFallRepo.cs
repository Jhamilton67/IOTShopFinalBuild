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
    public class FootFallRepo
    {
        public string ConnectionStringName;


        public FootFallRepo()
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

        public void AddData(FootFallClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"insert into dbo.FootFall (FootFallCounter)
                                values(@FootFallCounter)";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }

        }

        public IEnumerable<FootFallClass> GetAll()
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"SELECT  * FROM dbo.FootFall";
                dbConnection.Open();
                return dbConnection.Query<FootFallClass>(query);
            }
        }

        public FootFallClass GetAllByID(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"select Id, FootFallCounter 
	                            from dbo.FootFall;";
                dbConnection.Open();
                return dbConnection.Query<FootFallClass>(query, new { StockID = id }).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @"delete 
	                            from dbo.FootFall
	                            where Id = @Id;";
                dbConnection.Open();
                dbConnection.Execute(query, new { StockID = id });
            }
        }

        public void Update(FootFallClass stock)
        {
            using (IDbConnection dbConnection = DbConnection)
            {
                string query = @" update dbo.FootFall set 
                                FootFallCounter = @FootFallCounter,
                                where Id = @ID";
                dbConnection.Open();
                dbConnection.Execute(query, stock);
            }
        }


    }
}
