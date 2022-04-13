

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
    public class ReplenController : ControllerBase
    {
        private readonly MainRepo main;

        public ReplenController()
        {
            main = new MainRepo();
        }

        [HttpGet]
        public IEnumerable<ReplenModel> GET()
        {
            return main.GetAllReplenData();
        }

        [HttpGet("{id}")]
        public ReplenModel GetId(int id)
        {
            return main.RGETByID(id);
        }

        [HttpPost]
        public void Post([FromBody] ReplenModel stockTake)
        {
            if (ModelState.IsValid)
            {
                main.AddReplenData(stockTake);
            }
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] ReplenModel stockTake)
        {
            stockTake.StockID = id;
            if (ModelState.IsValid)
            {
                main.UpdateR(stockTake);
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            main.DeleteR(id);
        }
    }
}
