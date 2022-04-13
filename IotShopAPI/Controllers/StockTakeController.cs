
using IOTShopAPI.Repository;
using IOTShopDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTakeController : ControllerBase
    {
        private readonly MainRepo main;
        
        public StockTakeController()
        {
            main = new MainRepo();
        }
        // GET: api/<OverviewController>
        [HttpGet]
        public IEnumerable<StockTakeModel> GET()
        {
            return main.GetAllTakeModels(); 
        }
        // GET api/<OverviewController>/5
        [HttpGet("{id}")]
        public StockTakeModel GetId(int id)
        {
            return main.GETByID(id);
        }

        // POST api/<OverviewController>
        [HttpPost]
        public void Post([FromBody] StockTakeModel stockTake)
        {
            if(ModelState.IsValid)
            {
                main.AddStockTakeData(stockTake);
            }
        }
        // PUT api/<OverviewController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StockTakeModel stockTake)
        {
            stockTake.StockID = id;
            if (ModelState.IsValid)
            {
                main.Update(stockTake);
            }
        }
        // DELETE api/<OverviewController>/5
        [HttpDelete]
        public void Delete(int id)
        {
            main.Delete(id);
        }
    }
}
