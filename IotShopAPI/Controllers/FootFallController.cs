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
    public class FootFallController : ControllerBase
    {
        private readonly FootFallRepo footFall;

        public FootFallController()
        {
            footFall = new FootFallRepo();
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<FootFallClass> Get()
        {
            return footFall.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public FootFallClass Get(int id)
        {
            return footFall.GetAllByID(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] FootFallClass foot)
        {
            if(ModelState.IsValid)
            {
                footFall.AddData(foot);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FootFallClass foots)
        {

            if (ModelState.IsValid)
            {
                footFall.Update(foots);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            footFall.Delete(id);
        }
    }
}
