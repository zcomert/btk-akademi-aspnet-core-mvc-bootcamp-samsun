using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        protected readonly RepositoryContext _context;
        protected RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
           _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
           _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> filter = null)
        {
            return  filter is null ?  
                _context.Set<T>().ToList() : 
                _context.Set<T>().Where(filter);
        }

        public T FindById(Expression<Func<T, bool>> filter)
        {
            return _context
                .Set<T>()
                .Where(filter)
                .FirstOrDefault();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
