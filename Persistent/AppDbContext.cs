using dotnetCore.model;
using Microsoft.EntityFrameworkCore;
using S.model;

namespace dotnetCore.Persistent
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Features> Features { get; set; }
    }
}