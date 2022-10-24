using AutoMapper;
using Data.Repository;
using Domain.Entities.Team;
using MediatR;

namespace Application.Services.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;


        public Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _employeeRepository.GetById(request.Id);
            employee.ActiveAccount = false;
            _employeeRepository.Update(employee);

             return Task.FromResult(Unit.Value);
        }
    }
}
