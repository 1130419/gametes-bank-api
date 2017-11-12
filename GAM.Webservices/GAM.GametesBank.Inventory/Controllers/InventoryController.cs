using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GAM.GametesBank.Inventory.Controllers
{
    [Route("api/inventory")]
    public class InventoryController : Controller
    {
        // GET api/inventory
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/inventory/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/inventory
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/inventory/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/inventory/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
