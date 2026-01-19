using DigiMedia.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DigiMedia.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}
