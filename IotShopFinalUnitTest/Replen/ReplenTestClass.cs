using Autofac.Extras.Moq;
using IOTShopDataAccess.Data;
using IOTShopDataAccess.Data_Access;
using IOTShopDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IotShopFinalUnitTest.Replen
{
    public class ReplenTestClass
    {
        [Fact]
        public void Replen_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //mock.Mock<ISQLDataAccess>()
                //    .Setup(x => x.LoadData<ReplenModel>("SELECT * from dbo.Replen"))
                //    .Returns(GetSampleReplen ());

                //var cls = mock.Create<ReplenData>();
                //var expected = GetSampleReplen();
                //var actual = cls.GetReplens();

                //Assert.True(actual != null);
                //Assert.Equal(expected.Count, actual.Count);
            }
        }

        [Fact]
        public void SaveReplen_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
            //    var stock = GetSampleReplen();
            //    string sql = "INSERT into dbo.Replen (StockID, ReplenCount, StockType, StockTypeSize" +
            //        "StockTypeQuantityNeeded VALUES (@StockID, @ReplenCount, @StockType, @StockTypeSize, @StockTypeQuantityNeeded)";
            //      mock.Mock<ISQLDataAccess>()
            //        .Setup(x => x.SaveData(stock, sql));

            //    var cls = mock.Create<ReplenData>();
            //    var expected = GetSampleReplen();
            //    var actual = cls.GetReplens();

            //    Assert.True(actual != null);
            //    Assert.Equal(expected.Count, actual.Count);
            }
        }

        private List<ReplenModel> GetSampleReplen()
        {
            List<ReplenModel> stocks = new List<ReplenModel>()
            {
                new ReplenModel
                {
                     StockID = "12312", 
                     ReplenCount = "1231",
                     StockType =  "Juice",
                     StockTypeSize = "Cans",
                     StockTypeQuantityNeeded = "1"
                }
            };
            return GetSampleReplen();
        }
    }

}


   

