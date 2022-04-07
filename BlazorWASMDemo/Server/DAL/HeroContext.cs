using Microsoft.EntityFrameworkCore;

namespace BlazorWASMDemo.Server.DAL
{
    public class HeroContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<User> Users { get; set; }

        public HeroContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
