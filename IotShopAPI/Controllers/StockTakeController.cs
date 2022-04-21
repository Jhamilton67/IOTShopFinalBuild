using IOTShopAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IOTShopAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTakeController : ControllerBase
    {
        private readonly StockTakeRepo stockTake;

        public StockTakeController()
        {
            stockTake = new StockTakeRepo();
        }

        // GET: api/<StockTakeControllerAPI>
        [HttpGet]
        public IEnumerable<StockTakeClass> Get()
        {
            return stockTake.GetAll();
        }

        // GET api/<StockTakeControllerAPI>/5
        [HttpGet("{id}")]
        public StockTakeClass Get(int id)
        {
            return stockTake.GetAllByID(id);
        }

        // POST api/<StockTakeControllerAPI>
        [HttpPost]
        public void Post([FromBody] StockTakeClass Stocks)
        {
            if(ModelState.IsValid)
            {
                stockTake.AddData(Stocks);
            }
        }

        // PUT api/<StockTakeControllerAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StockTakeClass stock)
        {
            stock.StockID = id;
            if (ModelState.IsValid)
            {
                stockTake.Update(stock);
            }
        }

        // DELETE api/<StockTakeControllerAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            stockTake.Delete(id); 
        }
    }
}
