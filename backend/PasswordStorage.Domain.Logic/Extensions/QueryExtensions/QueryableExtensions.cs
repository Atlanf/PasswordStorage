using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Extensions.QueryExtensions
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

        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Func<TSource, int, bool> predicate)
        {
            if (condition)
            {
                Expression<Func<TSource, int, bool>> expression = (exp, i) => predicate(exp, i);
                return source.Where(expression);
            }
            else
            {
                return source;
            }
        }
    }
}
