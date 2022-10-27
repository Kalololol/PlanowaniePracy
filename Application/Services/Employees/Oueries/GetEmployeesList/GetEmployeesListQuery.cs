using MediatR;

namespace Application.Services.Employees.Queries
{
    public record GetEmployeesListQuery(int WardId) : IRequest<IQueryable<EmployeeModel>>;
/*    {
        public int WardId { get; set; }
    }*/
}
