using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO
        }
    }
}
