using InventoryServices.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryServices.Database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EN719380\\MSSQLSERVER01;Initial Catalog=InventoryService;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
