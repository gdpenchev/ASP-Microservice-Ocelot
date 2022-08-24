using Microsoft.AspNetCore.Mvc;
using OrderServices.Database;
using OrderServices.Database.Entities;

namespace OrderServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        DataBaseContext db;

        public OrderController()
        {
            db = new DataBaseContext();
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return db.Orders.ToList();
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Order order)
        {
            try
            {
                db.Orders.Add(order);
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
