using AutoMapper;
using Data.Repository;
using Domain.Entities.Team;
using MediatR;

namespace Application.Services.Employees.Queries
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDetailModel>
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IMapper _mapper;
        public GetEmployeeByIdQueryHandler(IRepository<Employee> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public Task<EmployeeDetailModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = _employeeRepository.GetById(request.Id);

            return Task.FromResult(_mapper.Map<EmployeeDetailModel>(employee));
        }


    }
}
