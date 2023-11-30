using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId =1, Name = "Horror", Description = "Scary", DisplayOrder = 0 },
                new Category { CategoryId = 2, Name = "Action", Description = "Rock Hard", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Cute", Description = "Kawaii", DisplayOrder = 0 });
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "C# Programming",
                    Description = "Hello",
                    Author = "Microsoft",
                    Price = 10,
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Advanced Programming",
                    Description = "Learning Harder",
                    Author = "BTEC",
                    Price = 11,
                    CategoryId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Java Programming",
                    Description = "Basic language",
                    Author = "Sun",
                    Price = 15,
                    CategoryId = 3
                },
                new Book
                {
                    Id = 4,
                    Title = "Data Structures",
                    Description = "Really not easy",
                    Author = "Greenwich",
                    Price = 20,
                    CategoryId = 1
                },
                new Book
                {
                    Id = 5,
                    Title = "App Dev",
                    Description = "Now",
                    Author = "Microsoft",
                    Price = 10,
                    CategoryId = 2
                }
            );
        }
    }
}
