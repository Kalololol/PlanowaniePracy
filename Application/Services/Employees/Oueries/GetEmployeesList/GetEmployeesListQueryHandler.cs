using AutoMapper;
using Data.Repository;
using Domain.Entities.Team;
using MediatR;

namespace Application.Services.Employees.Queries
{
    public class GetEmployeesListQueryHandler : IRequestHandler<GetEmployeesListQuery, IQueryable<EmployeeModel>>
    {

        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public Task<IQueryable<EmployeeModel>> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            var all = _employeeRepository.GetAllEmployeeInWard(request.WardId);
            

            return Task.FromResult(_mapper.Map<IQueryable<EmployeeModel>>(all));

        }
    }
}
