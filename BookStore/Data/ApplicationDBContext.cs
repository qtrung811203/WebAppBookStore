using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
    }
}
