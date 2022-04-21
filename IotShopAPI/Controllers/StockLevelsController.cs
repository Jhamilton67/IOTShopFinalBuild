using IOTShopAPI.Models;
using IOTShopAPI.Repository;
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

        private readonly StockLevelsRepo stockLevels;

        public StockLevelsController()
        {
            stockLevels = new StockLevelsRepo();
        }


        // GET: api/<StockLevelsController>
        [HttpGet]
        public IEnumerable<StockLevelsClass> Get()
        {
            return stockLevels.GetAll();
        }

        // GET api/<StockLevelsController>/5
        [HttpGet("{id}")]
        public StockLevelsClass Get(int id)
        {
            return stockLevels.GetAllByID(id);
        }

        // POST api/<StockLevelsController>
        [HttpPost]
        public void Post([FromBody] StockLevelsClass stocks)
        {
            if (ModelState.IsValid)
            {
                stockLevels.AddData(stocks);
            }
        }

        // PUT api/<StockLevelsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StockLevelsClass stock)
        {
            stock.StockID = id;
            if (ModelState.IsValid)
            {
                stockLevels.Update(stock);
            }
        }

        // DELETE api/<StockLevelsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            stockLevels.Delete(id);
        }
    }
}
