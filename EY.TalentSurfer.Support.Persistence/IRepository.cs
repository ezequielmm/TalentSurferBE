using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Support.Persistence
{
    public interface IRepository<T> : IOrderedQueryable<T> where T : Entity
    {
        Task<IEnumerable<T>> ToListAsync();
        Task<T> FindAsync(int id);
        Task<IEnumerable<T>> FindRangeAsync(IEnumerable<int> ids);
        Task DeleteAsync(T entity);
        Task InsertAsync(T entity);
        Task InsertAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateAsync(IEnumerable<T> entities);
        Task<bool> ExistsAsync(int id);
        Task<IEnumerable<T>> ToListAsync(int pageNum, int quantity, string orderColumn, bool ascendent);
        Task<int> CountAsync();
    }
}
