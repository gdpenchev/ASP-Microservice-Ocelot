using Microsoft.AspNetCore.Mvc;
using ProductServices.Database;
using ProductServices.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        DataBaseContext db;

        public ProductController()
        {
            db = new DataBaseContext();
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products.ToList();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return db.Products.Find(id);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            try
            {
                db.Products.Add(product);
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
