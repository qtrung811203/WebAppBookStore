using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public BookRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update(Book entity)
        {
            _dbContext.Books.Update(entity);
        }
    }
}
