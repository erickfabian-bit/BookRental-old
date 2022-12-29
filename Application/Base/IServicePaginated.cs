using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Paginations;

namespace Application.Base
{
    public interface IServicePaginated<TDto>
    {
        Task<ResponsePagination<TDto>> PaginatedSearch(RequestPagination<TDto> dto);
    }
}
