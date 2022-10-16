namespace Application.Dto
{
    public class PlanDayDto
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
