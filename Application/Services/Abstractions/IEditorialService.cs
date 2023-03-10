using Application.Base;
using Application.Dtos.Editoriales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstractions
{
    public interface IEditorialService : IServiceBase<EditorialDto, EditorialFormDto, int>, IServicePaginated<EditorialDto>
    {

    }
}
