using Microsoft.EntityFrameworkCore;
using ProductServices.Database.Entities;

namespace ProductServices.Database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EN719380\\MSSQLSERVER01;Initial Catalog=ProductService;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
