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
    public class ReplenController : ControllerBase
    {
        private readonly ReplenRepo replen;

        public ReplenController()
        {
            replen = new ReplenRepo();
        }

        // GET: api/<ReplenControllerAPI>
        [HttpGet]
        public IEnumerable<ReplenClass> Get()
        {
            return replen.GetAll();
        }

        // GET api/<ReplenControllerAPI>/5
        [HttpGet("{id}")]
        public ReplenClass Get(int id)
        {
            return replen.GetAllByID(id);
        }

        // POST api/<ReplenControllerAPI>
        [HttpPost]
        public void Post([FromBody] ReplenClass replens)
        {
            if (ModelState.IsValid)
            {
                replen.AddData(replens);
            }
        }

        // PUT api/<ReplenControllerAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReplenClass replenns)
        {
            replenns.StockID = id;
            if (ModelState.IsValid)
            {
                replen.Update(replenns);
            }
        }

        // DELETE api/<ReplenControllerAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            replen.Delete(id);
        }
    }
}
