using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Paginations;

namespace Infrastructure.Base
{
    public interface IRepositoryPaginated<T>
    {
        Task<ResponsePagination<T>> PaginatedSearch(RequestPagination<T> entity);
    }
}
