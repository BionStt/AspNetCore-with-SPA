using dotnetCore.model;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore.Persistent
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}