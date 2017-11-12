using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GAM.GametesBank.Statistics.Controllers
{
    [Route("api/statistics")]
    public class StatisticsController : Controller
    {
        // GET api/statistics
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/statistics/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/statistics
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/statistics/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/statistics/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
