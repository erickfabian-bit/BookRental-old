using Domain;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations
{
    public class EditorialRepository: IEditorialRepository
    {
        private readonly ApplicationDBContext _context;

        public EditorialRepository(ApplicationDBContext context) 
        {
            _context = context;
        }

        public async Task<Editorial> Create(Editorial entity)
        { 
            _context.Editoriales.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Editorial?> Edit(int id, Editorial entity) 
        {
            var model = await _context.Editoriales.FindAsync(id);
            if (model != null)
            {
                model.Codigo = entity.Codigo;
                model.Nombre = entity.Nombre;
                
                _context.Editoriales.Update(model);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<Editorial?> EnabledOrDisabled(int id)
        {
            var model = await _context.Editoriales.FindAsync(id);
            if (model != null)
            {
                model.Estado = (model.Estado == 0) ? 1 : 0;

                _context.Editoriales.Update(model);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<Editorial?> Find(int id)
        => await _context.Editoriales.FindAsync(id);

        public async Task<IList<Editorial>> FindAll()
        => await _context.Editoriales.OrderBy(e => e.Id).ToListAsync();
    }
}
