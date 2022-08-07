
using System.Linq.Expressions;


namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {        
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id);
        Task AddAsync (T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        void Update (T entity);
        void Delete (T entity);                
        void RemoveRange (IEnumerable<T> entity);
    }
}
