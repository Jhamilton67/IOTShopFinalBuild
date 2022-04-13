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
    public class FootFallController : ControllerBase
    {
        private readonly MainRepo main;

        public FootFallController()
        {
            main = new MainRepo();
        }

        [HttpGet]
        public IEnumerable<FootFallModel> GET()
        {
            return main.GetAllFootFallData();
        }

        [HttpGet("{id}")]
        public FootFallModel GetId(int id)
        {
            return main.FLGETByID(id);
        }

        [HttpPost]
        public void Post([FromBody] FootFallModel stockTake)
        {
            if (ModelState.IsValid)
            {
                main.AddFootFallData(stockTake);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FootFallModel stockTake)
        {
            stockTake.ID = id;
            if (ModelState.IsValid)
            {
                main.UpdateF(stockTake);
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            main.DeleteF(id); 
        }
    }
}
