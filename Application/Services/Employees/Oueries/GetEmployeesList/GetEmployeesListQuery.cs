using MediatR;

namespace Application.Services.Employees.Queries
{
    public class GetEmployeesListQuery : IRequest<IQueryable<EmployeeModel>>
    {
        public int WardId { get; set; }
    }
}
