using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Establishing the operations that will be needed
        Task AddAcitivtyAsync(TEntity entity);
        Task UpdateActivityAsync(TEntity entity);
        void DeleteActivity(TEntity entity);
        Task DeleteActivityAsync(TEntity entity);
        Task<TEntity> GetAcitvityByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllActivityAsync(int skip, int limit, IEnumerable<Expression<Func<TEntity, bool>>> predicates = null);
        Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate);

    }
}
