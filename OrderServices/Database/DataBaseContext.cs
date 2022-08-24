using Microsoft.EntityFrameworkCore;
using OrderServices.Database.Entities;

namespace OrderServices.Database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EN719380\\MSSQLSERVER01;Initial Catalog=OrderService;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
