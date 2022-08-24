using InventoryServices.Database;
using InventoryServices.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InventoryServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        DataBaseContext db;

        public InventoryController()
        {
            db = new DataBaseContext();
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public IEnumerable<Inventory> Get()
        {
            return db.Inventories.ToList();
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public Inventory Get(int id)
        {
            return db.Inventories.Find(id);
        }

        // POST api/<InventoryController>
        [HttpPost]
        public IActionResult Post([FromBody] Inventory inventory)
        {
            try
            {
                db.Inventories.Add(inventory);
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
