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

namespace IotShopFinalUnitTest.footfall
{
    public class FootFallTestClass
    {
        [Fact]
        public void FootFall_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
            //    mock.Mock<ISQLDataAccess>()
            //        .Setup(x => x.LoadData<StockTakeModel>("SELECT * from dbo.FootFall"))
            //        .Returns(GetSampleFootFall());

            //    var cls = mock.Create<FootFallData>();
            //    var expected = GetSampleFootFall();
            //    var actual = cls.GetFootFall();

            //    Assert.True(actual != null);
            //    Assert.Equal(expected.Count, actual.Count);
            }
        }


            private List<FootFallModel> GetSampleFootFall()
            {
                List<FootFallModel> stocks = new List<FootFallModel>()
                {
                    new FootFallModel
                    {
                         ID = 1241, 
                         FootFallCounter = "6765"
                    }
                };
                return GetSampleFootFall();
            }
    }
}
