using System.Linq.Expressions;

namespace BookStore.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperty = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperty = null);
        void Add(T entity);
        //void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
