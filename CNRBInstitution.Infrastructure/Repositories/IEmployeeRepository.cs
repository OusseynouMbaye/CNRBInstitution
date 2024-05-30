using CNRBInstitution.Domain.Entities;

namespace CNRBInstitution.Infrastructure.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        
       
    }
}
