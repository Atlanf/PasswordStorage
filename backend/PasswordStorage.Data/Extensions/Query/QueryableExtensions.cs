using System.Linq.Expressions;

namespace PasswordStorage.Data.Extensions.Query
{
    public static class QueryableExtensions
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Func<TSource, bool> predicate)
        {
            if (condition)
            {
                Expression<Func<TSource, bool>> expression = (exp) => predicate(exp);
                return source.Where(expression);
            }
            else
            {
                return source;
            }
        }
    }
}
