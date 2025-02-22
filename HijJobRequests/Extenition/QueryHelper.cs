using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace HijJobRequests.Extenition;

public static class QueryHelper
{
        public static async Task<(IEnumerable<T> Items, int TotalCount)> GetPagedAsync<T>(
        this IQueryable<T> query, 
        int pageIndex, 
        int pageSize, 
        Expression<Func<T, bool>> predicate = null) where T : class
    {
        query = predicate != null ? query.AsNoTracking().Where(predicate) : query.AsNoTracking();
        var totalCount = await query.CountAsync();
        var items = await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        return (items, totalCount);
    }

    public static IQueryable<T> WhereIf<T>(
        this IQueryable<T> query,
        bool condition,
        Expression<Func<T, bool>> predicate)
    {
        if (condition)
        {
            return query.Where(predicate);
        }
        return query;
    }
}
