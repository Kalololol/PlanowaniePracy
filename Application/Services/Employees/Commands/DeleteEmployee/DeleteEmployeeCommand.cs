using MediatR;

namespace Application.Services.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
