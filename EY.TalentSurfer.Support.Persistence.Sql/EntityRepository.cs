using EY.TalentSurfer.Support.Persistence.Exceptions;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Support.Persistence.Sql
{
    public class EntityRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly TalentSurferContext _context;

        public EntityRepository(TalentSurferContext context)
        {
            _context = context;
        }

        protected virtual IQueryable<T> Query => _context.Set<T>();
        protected virtual DbSet<T> Cosa => _context.Set<T>();
        public Type ElementType => Query.ElementType;
        public Expression Expression => Query.Expression;
        public IQueryProvider Provider => Query.Provider;
        public IEnumerator<T> GetEnumerator() => Query.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Query).GetEnumerator();

        public async Task<IEnumerable<T>> ToListAsync()
        {
            return await Query.Where(e => !e.Deleted).ToListAsync();
        }
   
        public async Task<T> FindAsync(int id)
        {
            return await Query.SingleOrDefaultAsync(e => !e.Deleted && e.Id == id);
        }

        public async Task<IEnumerable<T>> FindRangeAsync(IEnumerable<int> ids)
        {
            return await Query.Where(e => !e.Deleted).Where(e => ids.Contains(e.Id)).ToListAsync();
        }

        public async Task InsertAsync(T entity)
        {

          bool ifexist=await ExistsAsync(entity);
            await ExecuteAsync(async () =>
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync(true);
            });
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            await ExecuteAsync(async () =>
            {
                await _context.AddAsync(entities);
                await _context.SaveChangesAsync(true);
            });
        }

        public async Task UpdateAsync(T entity)
        {
            await ExecuteAsync(async () =>
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
            });
        }

        public async Task UpdateAsync(IEnumerable<T> entities)
        {
            await ExecuteAsync(async () =>
            {
                _context.UpdateRange(entities);
                await _context.SaveChangesAsync();
            });
        }

        public async Task DeleteAsync(T entity)
        {
            await ExecuteAsync(async () =>
            {
                entity.Deleted = true;
                _context.Update(entity);
                await _context.SaveChangesAsync();
            });
        }

        private async Task ExecuteAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (DbUpdateException ex)
            {
                throw new PersistenceException(ex.Message, ex);
            }
        }
        public async Task<bool> ExistsAsync(T entity)
        {
            
            return await Query.SingleOrDefaultAsync(e => e.Equals(entity)) != null;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await Query.SingleOrDefaultAsync(e => !e.Deleted && e.Id == id) != null;
        }

        public async Task<IEnumerable<T>> ToListAsync(int pageNum, int quantity, string orderColumn, bool ascendent)
        {
            orderColumn = char.ToUpper(orderColumn[0]) + orderColumn.Substring(1);
            if (!ascendent)
            {
                return await Query.Where(e => !e.Deleted)
                .OrderByDescending(e => typeof(T).GetProperty((orderColumn)).GetValue(e))
                .Skip((pageNum - 1) * quantity)
                .Take(quantity)
                .ToListAsync();
            }
            return await Query.Where(e => !e.Deleted)
            .OrderBy(e => typeof(T).GetProperty((orderColumn)).GetValue(e))
            .Skip((pageNum - 1) * quantity)
            .Take(quantity)
            .ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await Query.Where(e => !e.Deleted).CountAsync();
        }

        public async Task<bool> CheckIfValueExists(int? id, Expression<Func<T, bool>> exp)
        {
            return await Task.Run(() => Query.AsExpandable().Any(p => (id.HasValue ? p.Id != id : true) && exp.Invoke(p)));
        }
    }
}
