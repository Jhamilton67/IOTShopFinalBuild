using Autofac.Extras.Moq;
using IOTShopDataAccess.Data_Access;
using System;
using Xunit;

namespace IotShopUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public  void LoadStockTake_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<ISQLDataAccess>
            }

            throw new Exception();
        }
           
        public void UpdateStockTake_ValidCall()
        {

        }

        public void SaveStockTake_ValidCall()
        {

        }
    }
}
