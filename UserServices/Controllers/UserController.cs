using Microsoft.AspNetCore.Mvc;
using UserServices.Database;
using UserServices.Database.Entities;

namespace UserServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        DataBaseContext db;
        public UserController()
        {
            db = new DataBaseContext();
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
