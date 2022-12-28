using Application.Dtos.Editoriales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base
{
    public interface IServiceBase<TDto, TFormDto, K>
    {
        Task<TDto> Create(TFormDto dto);
        Task<TDto?> Edit(K id, TFormDto dto);
        Task<TDto?> EnabledOrDisabled(K id);
        Task<TDto?> Find(K id);
        Task<IList<TDto>> FindAll();
    }
}
