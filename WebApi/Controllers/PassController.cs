using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //A full name is clearer than an abbreviation, for example PasswordsController
    public class PassController : ControllerBase
    {
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
        public ActionResult<User> Post([FromBody] string pass)
        {
            int s = Zxcvbn.Core.EvaluatePassword(pass).Score;
            return Ok(s);
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
