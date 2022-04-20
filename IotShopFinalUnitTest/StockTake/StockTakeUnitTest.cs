using Bunit;
using IOTShopDataAccess.Data;
using IOTShopDataAccess.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IotShopFinalUnitTest.StockTake
{
    public class StockTakeUnitTest : TestContext
    {
        [Fact]
        public void StockTakeTest1()
        {
            //var stocktakeMoq = new Mock<IStockTakeData>();
            //stocktakeMoq.Setup(m => m.GetStockTakes())
              //  .Returns(Task.FromResult(result: new StockTakeModel[] { new StockTakeModel() { StockID = 1224123, StockTakeCount = 4444, StockType = "Beer", StockTypePrice = 5000, StockTypeSize = "Smallpack", StockTypeQuantity = "six", StockTypeColour = "red" } }));

            var messagingMoq = new Mock<IStockTakeData>();
        }
    }
}
