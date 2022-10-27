using MediatR;

namespace Application.Services.Employees.Queries
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<EmployeeDetailModel>;

}
