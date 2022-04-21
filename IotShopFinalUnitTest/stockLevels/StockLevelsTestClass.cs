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

namespace IotShopFinalUnitTest.stockLevels
{
    public class StockLevelsTestClass
    {
        [Fact]
        public void StockLevels_ValidCall()
        {

            using (var mock = AutoMock.GetLoose())
            {
                //mock.Mock<ISQLDataAccess>()
                //    .Setup(x => x.LoadData<StockLevelsModel>("SELECT * from dbo.StockLevels"))
                //    .Returns(GetSampleStockLevels());

                //var cls = mock.Create<StockLevelsData>();
                //var expected = GetSampleStockLevels();
                //var actual = cls.GetStockLevels();

                //Assert.True(actual != null);
                //Assert.Equal(expected.Count, actual.Count);
            }
        }

        private List<StockLevelsModel> GetSampleStockLevels()
        {
            List<StockLevelsModel> stocks = new List<StockLevelsModel>()
            {
                new StockLevelsModel
                {
                     StockID = 12412,
                     ID = 12412,
                     Quantity = "7",
                     StockLevels = "65"
                }
            };

            return GetSampleStockLevels();
        }
    }
}
