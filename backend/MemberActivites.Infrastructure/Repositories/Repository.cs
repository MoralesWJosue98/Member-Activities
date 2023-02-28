using MemberActivites.Infrastructure.Helpers;
using MemberActivities.Domain.Entities;
using MemberActivities.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivites.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> _entities;

        public Repository(DbSet<TEntity> entities)
        {
            _entities = entities;
        }

        public async Task AddAcitivtyAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public void DeleteActivity(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public async Task DeleteActivityAsync(TEntity entity)
        {
            await Task.Run(() => { DeleteActivity(entity); });
        }

        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.AnyAsync(predicate);
        }

        public async Task<TEntity> GetAcitvityByIdAsync(object id)
        {
            return await _entities.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<IEnumerable<TEntity>> GetAllActivityAsync(int skip, int limit, IEnumerable<Expression<Func<TEntity, bool>>> predicates = null)
        {
            return await _entities.Filter(predicates)
                 .Skip(skip)
                 .Take(limit).ToListAsync();
        }

        public async Task UpdateActivityAsync(TEntity entity)
        {
            await Task.Run(() => { _entities.Update(entity); });
        }
    }
}
