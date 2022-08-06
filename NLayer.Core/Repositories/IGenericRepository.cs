
using System.Linq.Expressions;


namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> where(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync (T entity);        
        void Update (T entity);
        void Delete (T entity);
        Task AddRangeAsync (IEnumerable<T> entity);        
        void RemoveRange (IEnumerable<T> entity);
    }
}
