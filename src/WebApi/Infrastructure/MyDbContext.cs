namespace Infrastructure
{
    public class MyDbContext
    {
        public DbSet<User> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }
}
