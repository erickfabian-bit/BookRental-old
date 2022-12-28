using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base
{
    public interface IRepositoryEditable<T, K>
    {
        Task<T?> Edit(K id, T entity);
        Task<T?> EnabledOrDisabled(K id);
    }
}
