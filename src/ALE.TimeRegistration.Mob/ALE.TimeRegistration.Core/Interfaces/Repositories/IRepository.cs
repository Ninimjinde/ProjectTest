using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetByIdAsync(Guid id);
        Task<T> GetByIdAsync(Guid id, string[] includes);
        IQueryable<T> GetAllAsync();
        Task<IEnumerable<T>> ListAllAsync();
        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> DeleteAsync(Guid id);

    }
}
