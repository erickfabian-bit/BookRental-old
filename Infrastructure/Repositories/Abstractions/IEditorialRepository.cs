using Domain;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Paginations;

namespace Infrastructure.Repositories.Abstractions
{
    public interface IEditorialRepository : IRepositoryCrud<Editorial, int>, IRepositoryPaginated<Editorial>
    {
    }
}
