using Application.Base;
using Application.Dtos.Libros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstractions
{
    public interface ILibroService : IServiceBase<LibroDto,LibroFormDto,int>
    {
    }
}
