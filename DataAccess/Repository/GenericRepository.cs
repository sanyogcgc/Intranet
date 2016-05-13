using DataAccess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    /// <summary>
    /// A generic repository for working with data in the database
    /// </summary>
    /// <typeparam name="T">A POCO that represents an Entity Framework entity</typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Properties

        /// <summary>
        /// The context
        /// </summary>
        internal ISHIRINTRANETContext context;

        /// <summary>
        /// The database set
        /// </summary>
        internal DbSet<T> dbSet;

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor to initialize type collection
        /// </summary>
        /// <param name="context">The context.</param>
        public GenericRepository(ISHIRINTRANETContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        #endregion Constructor

        #region CRUD Operations

        /// <summary>
        /// Performs read operation on database using db entity
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="proxyDefault">if set to <c>true</c> [proxy default].</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>,
            IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool proxyDefault = true)
        {
            if (!proxyDefault)
                context.Configuration.ProxyCreationEnabled = false;

            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.AsNoTracking().Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
                query = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        /// <summary>
        /// Performs read operation on database using db entity
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="proxyDefault">if set to <c>true</c> [proxy default].</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public virtual IEnumerable<T> GetWithTracking(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>,
            IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool proxyDefault = true)
        {
            if (!proxyDefault)
                context.Configuration.ProxyCreationEnabled = false;

            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        /// <summary>
        /// Performs read by id operation on database using db entity
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// T.
        /// </returns>
        public virtual T GetByID(object id)
        {
            T obj = dbSet.Find(id);
            context.Entry(obj).State = EntityState.Detached;
            return obj;
        }

        /// <summary>
        /// Performs read by id operation on database using db entity
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// T.
        /// </returns>
        public virtual T GetByIDWithTracking(object id)
        {
            T obj = dbSet.Find(id);
            return obj;
        }

        /// <summary>
        /// Gets the attached list.
        /// </summary>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public virtual IEnumerable<T> GetAttachedList()
        {
            return dbSet.Local.ToList();
        }

        /// <summary>
        /// Performs add operation on database using db entity
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Insert(T entity)
        {
            dbSet.Add(entity);
            
        }

        /// <summary>
        /// Performs delete by id operation on database using db entity
        /// </summary>
        /// <param name="id">The identifier.</param>
        public virtual void Delete(object id)
        {
            T entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Performs delete operation on database using db entity
        /// </summary>
        /// <param name="entityToDelete">The entity to delete.</param>
        public virtual void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Performs delete operation on database using db entity
        /// </summary>
        /// <param name="entityToDelete">The entity to delete.</param>
        public virtual void RemoveRange(List<T> entityToDelete)
        {
            dbSet.RemoveRange(entityToDelete);
        }

        /// <summary>
        /// Performs update operation on database using db entity
        /// </summary>
        /// <param name="entityToUpdate">The entity to update.</param>
        public virtual void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        /// <summary>
        /// Performs add operation on database using db entity
        /// </summary>
        /// <param name="entityList">The entity list.</param>
        public virtual void BulkInsert(List<T> entityList)
        {
            dbSet.AddRange(entityList);
        }

        /// <summary>
        /// Prepare query to perform read operation on database using db entity
        /// </summary>
        /// <param name="proxyDefault">if set to <c>true</c> [proxy default].</param>
        /// <returns>
        /// IQueryable&lt;T&gt;.
        /// </returns>
        public virtual IQueryable<T> GetQuery(bool proxyDefault = true)
        {
            if (!proxyDefault)
                context.Configuration.ProxyCreationEnabled = false;
            return dbSet.AsNoTracking();
        }

        /// <summary>
        /// Prepare query to perform read operation on database using db entity and with include property
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <param name="proxyDefault">if set to <c>true</c> [proxy default].</param>
        /// <returns>
        /// IQueryable&lt;T&gt;.
        /// </returns>
        public virtual IQueryable<T> GetQueryWithInclude(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>,
            IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool proxyDefault = true)
        {
            if (!proxyDefault)
                context.Configuration.ProxyCreationEnabled = false;

            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.AsNoTracking().Where(filter);
            }

            query = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy != null ? orderBy(query) : query;
        }

        #endregion CRUD Operations

        #region Sql Query Execution

        /// <summary>
        /// Performs get operation on database using stored procedure
        /// </summary>
        /// <param name="spName">Name of the sp.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// IEnumerable&lt;T&gt;.
        /// </returns>
        public virtual IEnumerable<T> ExecuteReadQuery(string spName, params object[] parameters)
        {
            return context.Database.SqlQuery<T>("exec " + spName, parameters).ToList();
        }

        /// <summary>
        /// Performs add/update/delete operation on database using stored procedure
        /// </summary>
        /// <param name="spName">Name of the sp.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// System.Int32.
        /// </returns>
        public virtual int ExecuteDmlQuery(string spName, params object[] parameters)
        {
            return context.Database.ExecuteSqlCommand("exec " + spName, parameters);
        }

        public virtual IEnumerable<T> ExecuteDDLQuery(string spName, params object[] parameters)
        {
            return context.Database.SqlQuery<T>("exec " + spName, parameters).ToList();
        }

        #endregion Sql Query Execution

        #region LINQ Extension

        /// <summary>
        /// Apply Paging.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="maxRecord">The maximum record.</param>
        /// <param name="totalResultCount">The total result count.</param>
        /// <returns>
        /// T.
        /// </returns>
        public static List<T> ApplyPaging(IQueryable<T> query, int pageIndex, int maxRecord, int totalResultCount)
        {
            if (totalResultCount == 0) return new List<T>();

            if (maxRecord != 0) return query.Skip((pageIndex - 1) * maxRecord).Take(maxRecord).ToList();
            maxRecord = totalResultCount;

            if (pageIndex == 0) pageIndex = 1;
            return query.Skip((pageIndex - 1) * maxRecord).Take(maxRecord).ToList();
        }

        /// <summary>
        /// Apply Sorting.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="sortExpressions">The sort expressions.</param>
        /// <returns>
        /// T.
        /// </returns>
        public static IOrderedEnumerable<T> ApplySorting(IQueryable<T> query, Tuple<string, string> sortExpressions)
        {
            // Apply sorting
            Func<T, object> expression = item => item.GetType()
                .GetProperty(sortExpressions.Item1)
                .GetValue(item, null);

            IOrderedEnumerable<T> orderedQuery = sortExpressions.Item2 == "ASC"
                ? query.OrderBy(expression)
                : query.OrderByDescending(expression);

            return orderedQuery;
        }

        /// <summary>
        /// Apply Sorting.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="sortColumn">The sort column.</param>
        /// <param name="direction">The direction.</param>
        /// <returns>
        /// T.
        /// </returns>
        public static IQueryable<T> OrderBy(IQueryable<T> query, string sortColumn, string direction)
        {
            string methodName = string.Format("OrderBy{0}", direction.ToLower() == "ascending" ? "" : "descending");
            ParameterExpression parameter = Expression.Parameter(query.ElementType, "p");
            MemberExpression memberAccess = sortColumn.Split('.')
                .Aggregate<string, MemberExpression>(null,
                    (current, property) => Expression.Property(current ?? (parameter as Expression), property));

            LambdaExpression orderByLambda = Expression.Lambda(memberAccess, parameter);
            MethodCallExpression result = Expression.Call(
                typeof(Queryable),
                methodName,
                new[] { query.ElementType, memberAccess.Type },
                query.Expression,
                Expression.Quote(orderByLambda));
            //
            return query.Provider.CreateQuery<T>(result);
        }

        #endregion LINQ Extension
    }
}