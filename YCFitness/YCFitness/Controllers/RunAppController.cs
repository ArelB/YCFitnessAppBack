using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YCFitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunAppController : ControllerBase
    {
        // GET: api/<RunAppController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/<RunAppController>
        [HttpGet("/getRun")]
        public IEnumerable<string> GetRun()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RunAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RunAppController>
        [HttpPost]
        public void Post()
        {
        }

        // PUT api/<RunAppController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RunAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
