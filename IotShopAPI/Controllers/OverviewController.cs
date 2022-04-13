using IOTShopAPI.Repository;
using IOTShopDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IOTShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OverviewController : ControllerBase
    {
        private readonly MainRepo main;

        public OverviewController()
        {
            main = new MainRepo();
        }
        // GET: api/<OverviewController>
        [HttpGet]
        public IEnumerable<OverviewModel> GET()
        {
            return main.GetAllOverviewData();
        }
        // GET api/<OverviewController>/5
        [HttpGet("{id}")]
        public OverviewModel GetId(int id)
        {
            return main.OGETByID(id);
        }

        // POST api/<OverviewController>
        [HttpPost]
        public void Post([FromBody] OverviewModel stockTake)
        {
            if (ModelState.IsValid)
            {
                main.AddOverviewData(stockTake);
            }
        }
        // PUT api/<OverviewController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OverviewModel stockTake)
        {
            stockTake.ID = id;
            if (ModelState.IsValid)
            {
                main.UpdateO(stockTake);
            }
        }
        // DELETE api/<OverviewController>/5
        [HttpDelete]
        public void Delete(int id)
        {
            main.DeleteO(id);
        }
    }
}
