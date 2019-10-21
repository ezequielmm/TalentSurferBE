using EY.TalentSurfer.Support.Persistence.Exceptions;
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
        private readonly TalentSurferContext _context;
        private readonly IQueryable<T> _query;

        public EntityRepository(TalentSurferContext context)
        {
            _context = context;
            _query = context.Set<T>();
        }

        public Type ElementType => _query.ElementType;
        public Expression Expression => _query.Expression;
        public IQueryProvider Provider => _query.Provider;
        public IEnumerator<T> GetEnumerator() => _query.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_query).GetEnumerator();

        public async Task<IEnumerable<T>> ToListAsync()
        {
            return await _query.ToListAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _query.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(T entity)
        {
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
                _context.Remove(entity);
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

        public async Task<bool> ExistsAsync(int id)
        {
            return await _query.SingleOrDefaultAsync(e => e.Id == id) != null;
        }
    }
}
