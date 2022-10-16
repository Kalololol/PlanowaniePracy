namespace Application.Dto
{
    public class WardDto
    {
        public string WardName { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
