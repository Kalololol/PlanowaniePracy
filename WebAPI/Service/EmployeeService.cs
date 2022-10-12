using Domain.Entities.Team;
using Infrastructure.Repositories;

namespace WebAPI.Service
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _employees;

        public EmployeeService(IRepository<Employee> employee)
        {
            _employees = employee;
        }

        
    }
}
