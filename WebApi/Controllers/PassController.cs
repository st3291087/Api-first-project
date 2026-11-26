using Microsoft.AspNetCore.Mvc;
using Entity;
using Repository;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassController : ControllerBase
    {
        IPassService passService;
        public PassController(IPassService passService)
        {
            this.passService = passService;
        }
        // GET: api/<PassController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PassController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PassController>
        [HttpPost]
      

        [HttpPost("ValidPass")]
        public IActionResult Post([FromBody] string pass)
        {
            return Ok(passService.Post(pass));
        }
        // PUT api/<PassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
