using Domain;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class EditorialRepository: IEditorialRepository
    {
        private readonly ApplicationDBContext _context;

        public EditorialRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public async Task<IList<Editorial>> findAll()
        => await _context.Editoriales.OrderBy(e => e.Id).ToListAsync();
    }
}
