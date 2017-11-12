using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GAM.GametesBank.Samples.Controllers
{
    [Route("api/samples")]
    public class SamplesController : Controller
    {
        // GET api/samples
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/samples/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/samples
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/samples/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/samples/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
