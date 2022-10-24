using AutoMapper;
using Data.Repository;
using Domain.Entities.Team;
using MediatR;

namespace Application.Services.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;
        public Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request);

            _employeeRepository.Add(employee);

            return Task.FromResult(employee.Id);
        }
    }
}
