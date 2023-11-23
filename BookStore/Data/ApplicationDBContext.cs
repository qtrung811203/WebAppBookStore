using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId =1, Name = "Horror", Description = "Scary", DisplayOrder = 0 },
                new Category { CategoryId = 2, Name = "Action", Description = "Rock Hard", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Cute", Description = "Kawaii", DisplayOrder = 0 });
        }
    }
}
