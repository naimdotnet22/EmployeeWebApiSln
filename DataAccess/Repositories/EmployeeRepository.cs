using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDbContext context) : base(context) { }
    }
}
