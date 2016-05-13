using ResourceUtilization.Utility;
using System.Linq;
using System.Linq.Expressions;

namespace ResourceUtilization.HtmlHelpers.Grid
{
    /// <summary>
    /// Defines the LINQ extensions.
    /// </summary>
    public static class LinqExtensions
    {
        /// <summary>
        /// Orders the sequence by specific column and direction.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <param name="sortColumn">The sort column.</param>
        /// <param name="direction">If set to "asc" then ascending otherwise descending.</param>
        /// <returns>
        /// IQueryable&lt;T&gt;.
        /// </returns>
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> query, string sortColumn, string direction)
        {
            var methodName = string.Format("OrderBy{0}", direction.ToLower() == Constants.SortAsc ? "" : Constants.SortDesc);
            var parameter = Expression.Parameter(query.ElementType, "p");
            var memberAccess = sortColumn.Split('.').Aggregate<string, MemberExpression>(null, (current, property) => Expression.Property(current ?? (parameter as Expression), property));
            
            var orderByLambda = Expression.Lambda(memberAccess, parameter);
            var result = Expression.Call(
                      typeof(Queryable),
                      methodName,
                      new[] { query.ElementType, memberAccess.Type },
                      query.Expression,
                      Expression.Quote(orderByLambda));
            //
            return query.Provider.CreateQuery<T>(result);
        }
    }
}