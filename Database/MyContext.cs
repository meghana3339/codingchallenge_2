using codingchallenge.Entities;
using Microsoft.EntityFrameworkCore;

namespace codingchallenge.Database
{
    public class MyContext : DbContext
    {
        private IConfiguration config;
        public MyContext(IConfiguration cfg)
        {
            config = cfg;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config["ConnectionString"]);
            base.OnConfiguring(optionsBuilder);
        }


    }
}
