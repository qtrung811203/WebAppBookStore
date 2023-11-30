using BookStore.Models;

namespace BookStore.Repository.IRepository
{
    public interface IBookRepository:IRepository<Book>
    {
        void Update(Book book);
    }
}
