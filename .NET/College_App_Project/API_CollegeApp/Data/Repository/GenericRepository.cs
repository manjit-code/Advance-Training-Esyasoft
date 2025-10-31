
using API_CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CollegeApp.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CollegeDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(CollegeDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            //var existEntity = await GetByIdAsync();
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return false;

            try
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // FK conflict (e.g., students linked to this course)
                if (ex.InnerException?.Message.Contains("REFERENCE constraint") == true)
                {
                    throw new InvalidOperationException("Cannot delete this record because it is referenced by other records.");
                }

                throw;
            }
        }


        public async Task<T> UpdateAsync(int id, T entity)
        {
            var exist = await GetByIdAsync(id);
            if (exist == null)
            {
                return null;
            }
            
            // copy updated values into the existing tracked entity
            _context.Entry(exist).CurrentValues.SetValues(entity);

            await _context.SaveChangesAsync();
            return exist;
        }

        public async Task<T> GetByNameAsync(string name)
        {
            // checks this entity type has 'courseName' or not
            var entityType = typeof(T);
            var courseNameProperty = entityType.GetProperty("CourseName");

            if (courseNameProperty != null)
            {
                return await _dbSet.FirstOrDefaultAsync(e => EF.Property<string>(e, "CourseName").ToLower().Trim() == name.ToLower().Trim());
            }

            return await _dbSet.FirstOrDefaultAsync(e => EF.Property<string>(e, "Name").ToLower().Trim() == name.ToLower().Trim());
        }
    }
}
