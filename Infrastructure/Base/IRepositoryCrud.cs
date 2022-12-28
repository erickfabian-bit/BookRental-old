using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base
{
    public interface IRepositoryCrud<T,K> : IRepositoryBase<T,K>, IRepositoryEditable<T, K>
    {
    }
}
