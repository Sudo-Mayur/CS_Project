using Core_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_API.ModelClasses
{
    public class ApiDbContext:DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RequiestInfo> requiestInfos { get; set; }
        public DbSet<ExceptionInfo> exceptionInfos { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasOne(c => c.Category) // One-To-One
                        .WithMany(p => p.Products) // One-To-Many
                        .HasForeignKey(p => p.CategoryRowId); // FOreign Key
            base.OnModelCreating(modelBuilder);
        }
    }
}



