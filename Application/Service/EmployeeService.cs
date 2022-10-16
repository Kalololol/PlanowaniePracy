using AutoMapper;
using Domain.Entities.Team;
using Data.Repository;

namespace Application.Service
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _employees;
        private readonly IMapper _mapper;

        public EmployeeService(IRepository<Employee> employee, IMapper mapper)
        {
            _employees = employee;
            _mapper = mapper;
        }

        public Employee Add (Employee employee)
        {
            _employees.Add(employee);

            return employee;

        }
    }
}
