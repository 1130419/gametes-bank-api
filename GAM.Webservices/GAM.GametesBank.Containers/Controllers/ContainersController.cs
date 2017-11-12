using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GAM.GametesBank.Containers.Controllers
{
    [Route("api/containers")]
    public class ContainersController : Controller
    {
        // GET api/containers
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/containers/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/containers
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/containers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/containers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
