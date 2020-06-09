using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BabyApp.API.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int CurentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotaCount { get; set; }
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotaCount = count;
            PageSize = pageSize;
            CurentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }
        // source -> our users (24 of them)
        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> source,
            int pageNumber, int pageSize)
            {
                var count = await source.CountAsync();
                var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                return new PagedList<T>(items, count, pageNumber, pageSize);
            }
    }
}