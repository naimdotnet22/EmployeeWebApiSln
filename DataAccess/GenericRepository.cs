using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly EmployeeDbContext _context;
        public GenericRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            Save();
            return entity;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            Save();
            return entity;
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
