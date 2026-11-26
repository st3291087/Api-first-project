using Entity;
using Entity.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Service;
using System.Collections;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        IUserService userService;
        IPassService passService;
        IConfiguration configuration;
        private readonly ILogger<UsersController> logger;
        public UsersController(IUserService userService, IConfiguration configuration, ILogger<UsersController> logger)
        {
            this.userService = userService;
            this.passService = passService;
            this.configuration = configuration;
            this.logger = logger;
            logger.LogInformation("user enter");
        }
       

        [HttpGet]
        public IEnumerable<string> Get()
        {
           
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {

            User user= await userService.Get(id);
                    if (user!=null)
                        return Ok(user);
            else return NotFound();
     
           
        }

    
        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            logger.LogInformation($"new user singing-\n his name: {user.FirstName} {user.LastName}, his email: {user.Email}, his password: {user.Password}");
            int StrengthOfPassword = passService.Post(user.Password);
            if (StrengthOfPassword < configuration.GetValue<int>("PasswordString", 3))
                return BadRequest();

            await userService.Post(user);

            return CreatedAtAction(nameof(Get), new {id=user.Id},user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Post([FromBody] loguser loginDetails)
        {
            User user = await userService.Post(loginDetails);
            if (user != null)
                return Ok(user);
            else return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] User userToUpdate)
        {

            int strenghOfPassword = passService.Post(userToUpdate.Password);
            if (strenghOfPassword < 3)
                return BadRequest();
           await userService.Put(id,userToUpdate);
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
