using Bressingham.Workshop.WebTools.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Bressingham.Workshop.WebTools.Data
{
    public class WebToolsContext : DbContext
    {
        public WebToolsContext(DbContextOptions<WebToolsContext> options)
            : base(options)
        {            
        }

        public DbSet<Material> Materials { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Material>()
                .ToTable("Material")
                .HasKey("MaterialId");
        }
    }
}
