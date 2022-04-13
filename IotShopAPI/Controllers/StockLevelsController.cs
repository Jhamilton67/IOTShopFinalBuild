using IOTShopAPI.Repository;
using IOTShopDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IOTShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockLevelsController : ControllerBase
    {
        private readonly MainRepo main;

        public StockLevelsController()
        {
            main = new MainRepo();
        }

        [HttpGet]
        public IEnumerable<StockLevelsModel> GET()
        {
            return main.GetAllStockLevels();
        }

        [HttpGet("{id}")]
        public StockLevelsModel GetId(int id)
        {
            return main.STLGETByID(id);
        }

        [HttpPost]
        public void Post([FromBody] StockLevelsModel stockTake)
        {
            if (ModelState.IsValid)
            {
                main.AddStockLevelsData(stockTake);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StockLevelsModel stockTake)
        {
            stockTake.ID = id;
            if (ModelState.IsValid)
            {
                main.UpdateSL(stockTake);
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            main.DeleteSL(id);
        }
    }
}
