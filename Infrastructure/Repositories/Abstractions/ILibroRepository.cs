using Domain;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Abstractions
{
    public interface ILibroRepository : IRepositoryCrud<Libro, int>
    {

    }
}
