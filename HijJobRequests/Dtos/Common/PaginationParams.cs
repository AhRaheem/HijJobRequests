using System;
namespace HijJobRequests.Dtos.Common
{
    public class PaginationParams
    {
        public int pageIndex {get;set;}=1; 
        public int pageSize {get;set;}=50; 
    }
}