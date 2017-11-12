using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GAM.GametesBank.DonationCycle.Controllers
{
    [Route("api/donation-cycle")]
    public class DonationCycleController : Controller
    {
        // GET api/donation-cycle
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/donation-cycle/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/donation-cycle
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/donation-cycle/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/donation-cycle/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
