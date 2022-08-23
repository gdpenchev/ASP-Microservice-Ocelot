using Microsoft.EntityFrameworkCore;
using UserServices.Database.Entities;

namespace UserServices.Database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EN719380\\MSSQLSERVER01;Initial Catalog=UserService;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
