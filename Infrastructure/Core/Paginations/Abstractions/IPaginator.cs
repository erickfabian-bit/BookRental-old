using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Paginations;

namespace Infrastructure.Core.Paginations.Abstractions
{
    public interface IPaginator<T>
    {
        Task<ResponsePagination<T>> Paginate(IQueryable<T> query, RequestPagination<T> request);
    }
}
