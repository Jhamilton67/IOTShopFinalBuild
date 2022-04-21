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

namespace IotShopFinalUnitTest.StockTake
{
    public class StockTakeTestClass
    {
        [Fact]
        public void StockTake_IsValid()
        {
            //using (var mock = AutoMock.GetLoose())
            //{
            //    mock.Mock<ISQLDataAccess>()
            //        .Setup(x => x.LoadData<StockTakeModel>("SELECT * from dbo.StockTake"))
            //        .Returns(GetSampleStockTake());

            //    var cls = mock.Create<StockTakeData>();
            //    var expected = GetSampleStockTake();
            //    var actual = cls.GetStockTakes();

            //    Assert.True(actual != null);
            //    Assert.Equal(expected.Count, actual.Count);
            //}

        }
    
        private List<StockTakeModel> GetSampleStockTake()
        {
            List<StockTakeModel> stocks = new List<StockTakeModel>()
            {
                new StockTakeModel
                {
                     StockID = 12412,
                     StockTakeCount = 222, 
                     StockType = "Cola",
                     StockTypeColour = "Red",
                     StockTypePrice = 2500, 
                     StockTypeSize = "Two liter",
                     StockTypeQuantity = "50"
                }
            };
            return GetSampleStockTake();
        }
    
    }

}
