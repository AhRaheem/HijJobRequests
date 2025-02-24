using System;
using System.Linq.Expressions;
using HijJobRequests.Dtos.Common;
using Microsoft.EntityFrameworkCore;
using HijJobRequests.Dtos.Common;

namespace HijJobRequests.Extenition;

public static class QueryHelper
{
        public static async Task<PaginationList<T>> GetPagedAsync<T>(
        this IQueryable<T> query, 
        PaginationParams paginationParams, 
        Expression<Func<T, bool>> predicate = null) where T : class
    {
        query = predicate != null ? query.AsNoTracking().Where(predicate) : query.AsNoTracking();
        var totalCount = await query.CountAsync();
        var Data = new PaginationList<T>
        {
            List = await query.Skip((paginationParams.pageIndex - 1) * paginationParams.pageSize).Take(paginationParams.pageSize).ToListAsync(),
            PageSize = paginationParams.pageSize,
            TotalCount = totalCount
        };
        return Data;
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
