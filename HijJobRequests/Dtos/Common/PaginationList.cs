using System;
namespace HijJobRequests.Dtos.Common
{
    public class PaginationList<T>
    {
        public IEnumerable<T> List { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}