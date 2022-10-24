using MediatR;

namespace Application.Services.Employees.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDetailModel>
    {
        public int Id { get; set; }

    }
}
