using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    /// <summary>
    /// Interface IGenericRepository
    /// </summary>
    /// <typeparam name="TEntity">The type of the t entity.</typeparam>
    internal interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="proxyDefault">if set to <c>true</c> [proxy default].</param>
        /// <returns>
        /// IEnumerable&lt;TEntity&gt;.
        /// </returns>
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", bool proxyDefault = true);

        /// <summary>
        /// Gets the with tracking.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="proxyDefault">if set to <c>true</c> [proxy default].</param>
        /// <returns>
        /// IEnumerable&lt;TEntity&gt;.
        /// </returns>
        IEnumerable<TEntity> GetWithTracking(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", bool proxyDefault = true);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="entityId">The entity identifier.</param>
        /// <returns>
        /// TEntity.
        /// </returns>
        TEntity GetByID(object entityId);

        /// <summary>
        /// Gets the by identifier with tracking.
        /// </summary>
        /// <param name="entityId">The entity identifier.</param>
        /// <returns>
        /// TEntity.
        /// </returns>
        TEntity GetByIDWithTracking(object entityId);

        /// <summary>
        /// Gets the attached list.
        /// </summary>
        /// <returns>
        /// IEnumerable&lt;TEntity&gt;.
        /// </returns>
        IEnumerable<TEntity> GetAttachedList();

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Insert(TEntity entity);

        /// <summary>
        /// Deletes the specified entity identifier.
        /// </summary>
        /// <param name="entityId">The entity identifier.</param>
        void Delete(object entityId);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(TEntity entity);
    }
}