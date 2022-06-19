using DataAccess.Repositories;
using Domain.Interfaces;


namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDbContext _context;
        public UnitOfWork(EmployeeDbContext context)
        {
            _context = context;
            Employee = new EmployeeRepository(_context);
        }

        public IEmployeeRepository Employee { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
